using MetroFramework.Forms;
using System;
using System.Linq;

namespace TennisApp
{
    public partial class MainForm : MetroForm
    {
        private readonly User _user;

        public MainForm(User user)
        {
            InitializeComponent();

            _user = user;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (_user is null) throw new System.Exception();

            var userParams = _user.UserParameters.Last();

            Text = $"Тренировка: {_user.surname} {_user.name}";
            txtTraining.Text = userParams.Training.textTraining.Replace("\n", Environment.NewLine);
            lblStart.Text = userParams.dateOfStart;
            lblEnd.Text = userParams.dateOfEnd;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnStartNew_Click(object sender, System.EventArgs e)
        {

        }
    }
}