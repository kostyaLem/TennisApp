namespace TennisApp
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnReg = new MetroFramework.Controls.MetroButton();
            this.btnAuth = new MetroFramework.Controls.MetroButton();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.AuthPanel = new MetroFramework.Controls.MetroPanel();
            this.AwaitPanel = new MetroFramework.Controls.MetroPanel();
            this.ErrorPanel = new MetroFramework.Controls.MetroPanel();
            this.btnRepeat = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.AuthPanel.SuspendLayout();
            this.AwaitPanel.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtLogin
            // 
            // 
            // 
            // 
            this.txtLogin.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtLogin.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txtLogin.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtLogin.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.txtLogin.CustomButton.Name = "";
            this.txtLogin.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogin.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogin.CustomButton.UseSelectable = true;
            this.txtLogin.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtLogin.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLogin.Lines = new string[0];
            resources.ApplyResources(this.txtLogin, "txtLogin");
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PromptText = "Введите логин";
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.UseSelectable = true;
            this.txtLogin.WaterMark = "Введите логин";
            this.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtPassword.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.txtPassword.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtPassword.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin1")));
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPassword.Lines = new string[0];
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Введите пароль";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Введите пароль";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnReg
            // 
            this.btnReg.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnReg, "btnReg");
            this.btnReg.Name = "btnReg";
            this.btnReg.UseSelectable = true;
            this.btnReg.UseStyleColors = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnAuth
            // 
            this.btnAuth.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnAuth, "btnAuth");
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.UseSelectable = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // metroProgressSpinner1
            // 
            resources.ApplyResources(this.metroProgressSpinner1, "metroProgressSpinner1");
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.Name = "metroLabel3";
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.White;
            this.AuthPanel.Controls.Add(this.btnAuth);
            this.AuthPanel.Controls.Add(this.txtPassword);
            this.AuthPanel.Controls.Add(this.btnReg);
            this.AuthPanel.Controls.Add(this.metroLabel1);
            this.AuthPanel.Controls.Add(this.metroLabel2);
            this.AuthPanel.Controls.Add(this.txtLogin);
            this.AuthPanel.HorizontalScrollbarBarColor = true;
            this.AuthPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AuthPanel.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.AuthPanel, "AuthPanel");
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.VerticalScrollbarBarColor = true;
            this.AuthPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AuthPanel.VerticalScrollbarSize = 10;
            // 
            // AwaitPanel
            // 
            this.AwaitPanel.Controls.Add(this.metroLabel3);
            this.AwaitPanel.Controls.Add(this.metroProgressSpinner1);
            this.AwaitPanel.HorizontalScrollbarBarColor = true;
            this.AwaitPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AwaitPanel.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.AwaitPanel, "AwaitPanel");
            this.AwaitPanel.Name = "AwaitPanel";
            this.AwaitPanel.VerticalScrollbarBarColor = true;
            this.AwaitPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AwaitPanel.VerticalScrollbarSize = 10;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.btnRepeat);
            this.ErrorPanel.Controls.Add(this.metroLabel4);
            this.ErrorPanel.HorizontalScrollbarBarColor = true;
            this.ErrorPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ErrorPanel.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.ErrorPanel, "ErrorPanel");
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.VerticalScrollbarBarColor = true;
            this.ErrorPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ErrorPanel.VerticalScrollbarSize = 10;
            // 
            // btnRepeat
            // 
            this.btnRepeat.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnRepeat, "btnRepeat");
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.UseSelectable = true;
            this.btnRepeat.UseStyleColors = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.Name = "metroLabel4";
            // 
            // AuthForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AuthPanel);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.AwaitPanel);
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.Resizable = false;
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.AwaitPanel.ResumeLayout(false);
            this.AwaitPanel.PerformLayout();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnAuth;
        private MetroFramework.Controls.MetroButton btnReg;
        private MetroFramework.Controls.MetroPanel AuthPanel;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel AwaitPanel;
        private MetroFramework.Controls.MetroPanel ErrorPanel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnRepeat;
    }
}

