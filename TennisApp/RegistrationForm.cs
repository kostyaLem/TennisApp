﻿using MetroFramework;
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

            this.Load += RegistrationForm_Load;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            TennisSettings.TennisContext.IdealParameters.ToList().ForEach(x =>
            {
                dtgIdealParams.Rows.Add(x.age, x.gender == 0 ? "М" : "Ж", x.dinamometry, x.excursion);
            });
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var age = GetAge(dtpDateBirthday.Value);
            if (age < 16 || age > 23)
            {
                MetroMessageBox.Show(this, $"Допустимый возраст: от 16 до 23", "Сообщение");
                return;
            }


            //TODO: check if user existed and fields is empty

            try
            {
                User user = CreateUser();
                UserParameter userParams = CreateUserParameter();
                user.UserParameters.Add(userParams);

                var gender = (rbMen.Checked) ? 0 : 1;

                var idealParams = TennisSettings.TennisContext.IdealParameters.FirstOrDefault(new Func<IdealParameter, bool>(param =>
                {
                    var interval = param.age.Split('-').Select(x => int.Parse(x)).ToArray();
                    var (lowerAge, upperAge) = (interval[0], interval[1]);

                    return (InRange(lowerAge, upperAge, age) && param.gender == gender) ? true : false;
                }));

                if (idealParams != null)
                {
                    var idealWeight = (rbMen.Checked) ? 0.9 * (userParams.height - 100) : 0.85 * (userParams.height - 100);
                    var idealDyn = idealParams.dinamometry.Split('-').Select(x => double.Parse(x.Replace('.', ','))).ToArray();

                    var (lowerWeight, upperWeight) = (idealWeight - 5, idealWeight + 5);
                    var (lowerDyn, upperDyn) = (idealDyn[0], idealDyn[1]);

                    if (double.Parse(idealParams.excursion) < userParams.excursion ||
                        !InRange(lowerWeight, upperWeight, userParams.weight))
                    {
                        userParams.Training = GetTraining(userParams, TrainingTypes.WeightAndExcursion);
                    }
                    else if (!InRange(lowerDyn, upperDyn, userParams.dynamometry) ||
                        !PowerIsNormal(userParams.dynamometry / userParams.weight, gender))
                    {
                        userParams.Training = GetTraining(userParams, TrainingTypes.DynamometryAndForse);
                    }
                    else
                    {
                        userParams.Training = GetTraining(userParams, TrainingTypes.IdealParams);
                    }

                    TennisSettings.TennisContext.Users.Add(user);
                    TennisSettings.TennisContext.SaveChanges();

                    MetroMessageBox.Show(this, $"Пользователь с ником {user.login} успешно зарегистрирован.", "Сообщение");
                }
                else
                {
                    MetroMessageBox.Show(this, "Не удалось определить \"уровень\" по заданным параметрам...", "Сообщение");
                }
            }
            catch (Exception exc)
            {
                MetroMessageBox.Show(this, $"Не удалось зарегистрировать пользователя\nДополнительно:{exc}", "Сообщение", 300);
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
                dateOfStart = DateTime.Now.ToShortDateString(),
                dateOfEnd = DateTime.Now.AddMonths(1).ToShortDateString()
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
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(birthDate.ToString("yyyyMMdd"));
            return (now - dob) / 10000;
        }
    }
}