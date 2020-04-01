using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TennisApp
{
    public partial class AuthForm : MetroForm
    {
        private bool _connectionSuccessful = true;
        private const int _timeout = 5_000;

        public AuthForm()
        {
            InitializeComponent();
            this.Load += AuthForm_Load;
        }

        private async void AuthForm_Load(object sender, EventArgs e)
        {
            AuthPanel.Visible = false;
            ErrorPanel.Visible = false;
            AwaitPanel.Visible = true;

            var connectionTask = Task.Run(() =>
             {
                 try
                 {
                     TennisSettings.TennisContext.Users.ToArray();
                     _connectionSuccessful = true;
                 }
                 catch (Exception)
                 {
                     _connectionSuccessful = false;
                 }
             });

            await Task.WhenAny(connectionTask, Task.Delay(_timeout));

            AuthPanel.Invoke(new Action(() =>
            {
                AwaitPanel.Visible = false;

                if (_connectionSuccessful)
                {
                    AuthPanel.Visible = true;
                }
                else
                {
                    ErrorPanel.Visible = true;
                }
            }));
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "Проверьте введенные данные...", "Ошибка авторизации", 150);
                return;
            }

            var login = txtLogin.Text.Trim();
            var passwordHash = Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(txtLogin.Text.Trim())));

            var user = TennisSettings.TennisContext.Users.FirstOrDefault(u => u.login == login && u.hashPassword == passwordHash);
            if (user != null)
            {                
                this.Visible = false;
                new MainForm(user).ShowDialog();
                this.Visible = true;
            }
            else
            {
                MetroMessageBox.Show(this, "Логин или пароль не подходит ...", "Ошибка авторизации", 150);
                return;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new RegistrationForm().ShowDialog(this);
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            AuthForm_Load(sender, e);
        }
    }
}
