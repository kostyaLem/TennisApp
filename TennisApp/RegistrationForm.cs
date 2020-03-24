using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TennisApp
{
    public partial class RegistrationForm : MetroForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //TODO: check if user existed and fields is empty

            User user = CreateUser();
            UserParameter userParams = CreateUserParameter();
            user.UserParameters.Add(userParams);

            var gender = (rbMen.Checked) ? 0 : 1;
            var age = GetAge(dtpDateBirthday.Value);

            var idealParams = TennisSettings.TennisContext.IdealParameters.FirstOrDefault(new Func<IdealParameter, bool>(param =>
            {
                var interval = param.age.Split('-').Select(x => int.Parse(x)).ToArray();
                var (lowerAge, upperAge) = (interval[0], interval[1]);

                return (InRange(lowerAge, upperAge, age) && param.gender == gender) ? true : false;
            }));

            if (idealParams != null)
            {
                var idealWeight = (rbMen.Checked) ? 0.9 * (userParams.height - 100) : 0.85 * (userParams.height - 100);
                var idealDyn = idealParams.dinamometry.Split('-').Select(x => double.Parse(x.Replace('.',','))).ToArray();

                var (lowerWeight, upperWeight) = (idealWeight - 5, idealWeight + 5);
                var (lowerDyn, upperDyn) = (idealDyn[0], idealDyn[1]);

                if (double.Parse(idealParams.excursion) < userParams.excursion ||
                    !InRange(lowerWeight, upperWeight, userParams.weight))
                {
                    userParams.Training = GetTraining(userParams, TrainingTypes.WeightAndExcursion);
                }
                else if (!InRange(lowerDyn, upperDyn, userParams.dynamometry) || 
                    !PowerIsNormal(userParams.dynamometry/userParams.weight, gender))
                {
                    userParams.Training = GetTraining(userParams, TrainingTypes.DynamometryAndForse);
                }
                else
                {
                    userParams.Training = GetTraining(userParams, TrainingTypes.IdealParams);
                }

                TennisSettings.TennisContext.Users.Add(user);               
                TennisSettings.TennisContext.SaveChanges();
            }
            else
            {
                MetroMessageBox.Show(this, "Не удалось определить \"уровень\" по заданным параметрам...");
            }
        }

        private Training GetTraining(UserParameter userParams, TrainingTypes trainingType)
        {
            return TennisSettings.TennisContext.Trainings.First(x => x.level == userParams.level && x.trainingTypeId == (int)trainingType);
        }

        private UserParameter CreateUserParameter()
        {
            return new UserParameter()
            {
                level = cmbLevel.SelectedIndex + 1,
                height = double.Parse(txtHeight.Text.Trim()),
                weight = double.Parse(txtWeight.Text.Trim()),
                dynamometry = double.Parse(txtDin.Text.Trim()),
                excursion = double.Parse(txtExc.Text.Trim()),
                dateOfStart = DateTime.Now.ToString(),
                dateOfEnd = DateTime.Now.AddDays(30).ToString(),
                // dateOfSParametersSet = DateTime.Now.ToString()
            };
        }

        private User CreateUser()
        {
            return new User()
            {
                surname = txtSurname.Text.Trim(),
                name = txtName.Text.Trim(),
                dateOfBirth = dtpDateBirthday.Value.ToString(),
                gender = rbMen.Checked ? 1 : 0,
                IsDefaultUser = 1,
                login = txtLogin.Text.Trim(),
                hashPassword = Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text)))
            };
        }

        private bool InRange<T>(T min, T max, T value) where T : struct
        {
            var minCompare = Comparer<T>.Default.Compare(value, min);
            var maxCompare = Comparer<T>.Default.Compare(value, max);

            if (minCompare == 0 || maxCompare == 0)
            {
                return true;
            }
            else if (minCompare == 1 && maxCompare == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PowerIsNormal(double powerIndex, int gender)
        {
            if (gender == 0)
            {
                return powerIndex * 100 >= 65;
            }
            else
            {
                return powerIndex * 100 >= 50;
            }
        }

        private int GetAge(DateTime birthDate)
        {
            var now = DateTime.Today;
            return now.Year - birthDate.Year - 1 +
                ((now.Month > birthDate.Month || now.Month == birthDate.Month && now.Day >= birthDate.Day) ? 1 : 0);
        }
    }
}