using MetroFramework;
using MetroFramework.Forms;
using System;
using System.CodeDom;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TennisApp.Extensions;

namespace TennisApp
{
    public partial class AdminForm : MetroForm
    {
        public AdminForm()
        {
            InitializeComponent();

            this.Load += AdminForm_Load;
        }

        private void AdminForm_Load(object sender, System.EventArgs e)
        {
            UpdateDtgUsers();

            UpdateDtgTrainings();

            dtgUsers.ClearSelection();

            var count = 0;
            foreach (var item in Enum.GetValues(typeof(TrainingTypes)))
                cmbType.Items.Add($"{++count} - {((TrainingTypes)item).GetAttributeOfType<DescriptionAttribute>().Description}");
        }

        private void UpdateDtgUsers()
        {
            dtgUsers.Rows.Clear();

            TennisSettings.TennisContext.Users.ToList().ForEach(user =>
            {
                var index = dtgUsers.Rows.Add();
                var row = dtgUsers.Rows[index];

                row.Cells[0].Value = user.login;
                row.Cells[1].Value = user.IsDefaultUser == 1 ? "Спортсмен" : "Администратор";
                row.Tag = user;
            });
        }

        private void UpdateDtgTrainings()
        {
            dtgTrains.Rows.Clear();

            TennisSettings.TennisContext.Trainings.ToList().ForEach(training =>
            {
                var index = dtgTrains.Rows.Add();
                var row = dtgTrains.Rows[index];

                row.Cells[0].Value = training.level;
                row.Cells[1].Value = ((TrainingTypes)training.trainingTypeId).GetAttributeOfType<DescriptionAttribute>().Description;
                row.Tag = training;
            });
        }

        private void btnDel_Click(object sender, System.EventArgs e)
        {
            var row = dtgUsers.SelectedRows[0];
            var user = row.Tag as User;

            DataGridViewRow[] rows = new DataGridViewRow[dtgUsers.RowCount];
            dtgUsers.Rows.CopyTo(rows, 0);

            if (user.IsDefaultUser == 0 && rows.Count(x => (x.Tag as User).IsDefaultUser == 0) == 1)
            {
                MetroMessageBox.Show(this, $"Невозможно удалить последнего администратора", "Сообщение");
                return;
            }

            TennisSettings.TennisContext.Users.Remove(user);
            TennisSettings.TennisContext.SaveChanges();
            dtgUsers.Rows.Remove(row);
        }

        private void dtgIdealParams_SelectionChanged(object sender, System.EventArgs e) =>
            btnDel.Enabled = dtgUsers.SelectedRows.Count != 0 ? true : false;

        private void dtgTrains_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dtgTrains.SelectedRows.Count != 0)
            {
                btnChange.Enabled = btnDel.Enabled = true;

                if (dtgTrains.SelectedRows[0].Tag is Training training && training != null)
                {
                    cmbLevel.SelectedIndex = (int)training.level - 1;
                    cmbType.SelectedIndex = (int)training.trainingTypeId - 1;
                    txtText.Text = training.textTraining.Replace("\n", Environment.NewLine);
                }
            }
            else
            {
                btnChange.Enabled = btnDel.Enabled = false;

                cmbLevel.SelectedIndex = -1;
                cmbType.SelectedIndex = -1;
                txtText.Text = string.Empty;
            }
        }

        private void btnClearSelect(object sender, EventArgs e)
        {
            dtgTrains.ClearSelection();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var row = dtgTrains.SelectedRows[0];
            
            var training = row.Tag as Training;
            var index = row.Index;

            var level = cmbLevel.SelectedIndex + 1;
            var type = cmbType.SelectedIndex + 1;
            var text = txtText.Text.Trim();

            if (TennisSettings.TennisContext.Trainings.ToList().Any(x => x.level == level && x.trainingTypeId == type && x.id != training.id))
            {
                MetroMessageBox.Show(this, $"Тренировка с таким уровнем подготовки и типом уже существует", "Сообщение");
                return;
            }

            training.trainingTypeId = type;
            training.level = level;
            training.textTraining = text;
            TennisSettings.TennisContext.Entry(training).State = System.Data.Entity.EntityState.Modified;
            TennisSettings.TennisContext.SaveChanges();

            UpdateDtgTrainings();
            dtgTrains.Rows[index].Selected = true;
        }
    }
}
