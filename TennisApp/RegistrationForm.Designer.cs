﻿namespace TennisApp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.rnW = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.rbMen = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtpDateBirthday = new MetroFramework.Controls.MetroDateTime();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPatronymic = new MetroFramework.Controls.MetroTextBox();
            this.txtSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cmbLevel = new MetroFramework.Controls.MetroComboBox();
            this.txtDin = new MetroFramework.Controls.MetroTextBox();
            this.txtWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtHeight = new MetroFramework.Controls.MetroTextBox();
            this.txtExc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btnReg = new MetroFramework.Controls.MetroButton();
            this.tabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Controls.Add(this.metroTabPage2);
            this.tabControl.Location = new System.Drawing.Point(23, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(754, 277);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage1.Controls.Add(this.rnW);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.rbMen);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.dtpDateBirthday);
            this.metroTabPage1.Controls.Add(this.txtName);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.txtPatronymic);
            this.metroTabPage1.Controls.Add(this.txtSurname);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.txtPassword);
            this.metroTabPage1.Controls.Add(this.txtLogin);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 235);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Данные регистрации";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // rnW
            // 
            this.rnW.AutoSize = true;
            this.rnW.Location = new System.Drawing.Point(631, 165);
            this.rnW.Name = "rnW";
            this.rnW.Size = new System.Drawing.Size(34, 15);
            this.rnW.TabIndex = 59;
            this.rnW.Text = "Ж";
            this.rnW.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(471, 160);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 25);
            this.metroLabel7.TabIndex = 58;
            this.metroLabel7.Text = "Пол:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // rbMen
            // 
            this.rbMen.AutoSize = true;
            this.rbMen.Location = new System.Drawing.Point(571, 165);
            this.rbMen.Name = "rbMen";
            this.rbMen.Size = new System.Drawing.Size(34, 15);
            this.rbMen.TabIndex = 57;
            this.rbMen.Text = "М";
            this.rbMen.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(8, 182);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(154, 25);
            this.metroLabel5.TabIndex = 56;
            this.metroLabel5.Text = "Дата рождения:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // dtpDateBirthday
            // 
            this.dtpDateBirthday.Location = new System.Drawing.Point(168, 180);
            this.dtpDateBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateBirthday.Name = "dtpDateBirthday";
            this.dtpDateBirthday.Size = new System.Drawing.Size(192, 29);
            this.dtpDateBirthday.TabIndex = 55;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtName.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(168, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.WaterMark = "Введите Имя";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(192, 28);
            this.txtName.TabIndex = 54;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Введите Имя";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(63, 128);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 25);
            this.metroLabel6.TabIndex = 53;
            this.metroLabel6.Text = "Отчество:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txtPatronymic
            // 
            // 
            // 
            // 
            this.txtPatronymic.CustomButton.Image = null;
            this.txtPatronymic.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPatronymic.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtPatronymic.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatronymic.CustomButton.Name = "";
            this.txtPatronymic.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPatronymic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatronymic.CustomButton.TabIndex = 1;
            this.txtPatronymic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatronymic.CustomButton.UseSelectable = true;
            this.txtPatronymic.CustomButton.Visible = false;
            this.txtPatronymic.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPatronymic.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPatronymic.Lines = new string[0];
            this.txtPatronymic.Location = new System.Drawing.Point(168, 128);
            this.txtPatronymic.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatronymic.MaxLength = 32767;
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.PasswordChar = '*';
            this.txtPatronymic.WaterMark = "Введите Отчество";
            this.txtPatronymic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatronymic.SelectedText = "";
            this.txtPatronymic.SelectionLength = 0;
            this.txtPatronymic.SelectionStart = 0;
            this.txtPatronymic.ShortcutsEnabled = true;
            this.txtPatronymic.Size = new System.Drawing.Size(192, 28);
            this.txtPatronymic.TabIndex = 52;
            this.txtPatronymic.UseSelectable = true;
            this.txtPatronymic.WaterMark = "Введите Отчество";
            this.txtPatronymic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatronymic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // txtSurname
            // 
            // 
            // 
            // 
            this.txtSurname.CustomButton.Image = null;
            this.txtSurname.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSurname.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtSurname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.CustomButton.Name = "";
            this.txtSurname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSurname.CustomButton.TabIndex = 1;
            this.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSurname.CustomButton.UseSelectable = true;
            this.txtSurname.CustomButton.Visible = false;
            this.txtSurname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSurname.Lines = new string[0];
            this.txtSurname.Location = new System.Drawing.Point(168, 21);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.WaterMark = "Введите Фамилию";
            this.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.ShortcutsEnabled = true;
            this.txtSurname.Size = new System.Drawing.Size(192, 28);
            this.txtSurname.TabIndex = 51;
            this.txtSurname.UseSelectable = true;
            this.txtSurname.WaterMark = "Введите Фамилию";
            this.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(107, 78);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 25);
            this.metroLabel3.TabIndex = 50;
            this.metroLabel3.Text = "Имя:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(63, 23);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 25);
            this.metroLabel4.TabIndex = 49;
            this.metroLabel4.Text = "Фамилия:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtPassword.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(534, 75);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.WaterMark = "Введите пароль";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(192, 28);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Введите пароль";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // txtLogin
            // 
            // 
            // 
            // 
            this.txtLogin.CustomButton.Image = null;
            this.txtLogin.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLogin.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtLogin.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.CustomButton.Name = "";
            this.txtLogin.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogin.CustomButton.TabIndex = 1;
            this.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogin.CustomButton.UseSelectable = true;
            this.txtLogin.CustomButton.Visible = false;
            this.txtLogin.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLogin.Lines = new string[0];
            this.txtLogin.Location = new System.Drawing.Point(534, 20);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.WaterMark = "Введите логин";
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(192, 28);
            this.txtLogin.TabIndex = 45;
            this.txtLogin.UseSelectable = true;
            this.txtLogin.WaterMark = "Введите логин";
            this.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(440, 77);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "Пароль:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(454, 22);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 25);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Логин:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.cmbLevel);
            this.metroTabPage2.Controls.Add(this.txtDin);
            this.metroTabPage2.Controls.Add(this.txtWeight);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.txtHeight);
            this.metroTabPage2.Controls.Add(this.txtExc);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 235);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Параметры человека";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(72, 164);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(196, 25);
            this.metroLabel12.TabIndex = 64;
            this.metroLabel12.Text = "Уровень подготовки:";
            this.metroLabel12.UseStyleColors = true;
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.ItemHeight = 23;
            this.cmbLevel.Items.AddRange(new object[] {
            "1 - Professional",
            "2 - Normal",
            "3 - Beginner"});
            this.cmbLevel.Location = new System.Drawing.Point(279, 162);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(381, 29);
            this.cmbLevel.TabIndex = 63;
            this.cmbLevel.UseSelectable = true;
            // 
            // txtDin
            // 
            // 
            // 
            // 
            this.txtDin.CustomButton.Image = null;
            this.txtDin.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDin.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtDin.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDin.CustomButton.Name = "";
            this.txtDin.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDin.CustomButton.TabIndex = 1;
            this.txtDin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDin.CustomButton.UseSelectable = true;
            this.txtDin.CustomButton.Visible = false;
            this.txtDin.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDin.Lines = new string[0];
            this.txtDin.Location = new System.Drawing.Point(225, 106);
            this.txtDin.Margin = new System.Windows.Forms.Padding(2);
            this.txtDin.MaxLength = 32767;
            this.txtDin.Name = "txtDin";
            this.txtDin.PasswordChar = '\0';
            this.txtDin.WaterMark = "Введите Динанометрию";
            this.txtDin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDin.SelectedText = "";
            this.txtDin.SelectionLength = 0;
            this.txtDin.SelectionStart = 0;
            this.txtDin.ShortcutsEnabled = true;
            this.txtDin.Size = new System.Drawing.Size(137, 28);
            this.txtDin.TabIndex = 62;
            this.txtDin.UseSelectable = true;
            this.txtDin.WaterMark = "Введите Динанометрию";
            this.txtDin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // txtWeight
            // 
            // 
            // 
            // 
            this.txtWeight.CustomButton.Image = null;
            this.txtWeight.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtWeight.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtWeight.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.CustomButton.Name = "";
            this.txtWeight.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWeight.CustomButton.TabIndex = 1;
            this.txtWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeight.CustomButton.UseSelectable = true;
            this.txtWeight.CustomButton.Visible = false;
            this.txtWeight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWeight.Lines = new string[0];
            this.txtWeight.Location = new System.Drawing.Point(225, 45);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.MaxLength = 32767;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.WaterMark = "Введите Вес";
            this.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeight.SelectedText = "";
            this.txtWeight.SelectionLength = 0;
            this.txtWeight.SelectionStart = 0;
            this.txtWeight.ShortcutsEnabled = true;
            this.txtWeight.Size = new System.Drawing.Size(137, 28);
            this.txtWeight.TabIndex = 61;
            this.txtWeight.UseSelectable = true;
            this.txtWeight.UseStyleColors = true;
            this.txtWeight.WaterMark = "Введите Вес";
            this.txtWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(72, 105);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(149, 25);
            this.metroLabel8.TabIndex = 60;
            this.metroLabel8.Text = "Динанометрия:";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(173, 45);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(48, 25);
            this.metroLabel9.TabIndex = 59;
            this.metroLabel9.Text = "Вес:";
            this.metroLabel9.UseStyleColors = true;
            // 
            // txtHeight
            // 
            // 
            // 
            // 
            this.txtHeight.CustomButton.Image = null;
            this.txtHeight.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHeight.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtHeight.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.CustomButton.Name = "";
            this.txtHeight.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHeight.CustomButton.TabIndex = 1;
            this.txtHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHeight.CustomButton.UseSelectable = true;
            this.txtHeight.CustomButton.Visible = false;
            this.txtHeight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtHeight.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtHeight.Lines = new string[0];
            this.txtHeight.Location = new System.Drawing.Point(523, 45);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.MaxLength = 32767;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '*';
            this.txtHeight.WaterMark = "Введите Рост";
            this.txtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHeight.SelectedText = "";
            this.txtHeight.SelectionLength = 0;
            this.txtHeight.SelectionStart = 0;
            this.txtHeight.ShortcutsEnabled = true;
            this.txtHeight.Size = new System.Drawing.Size(137, 28);
            this.txtHeight.TabIndex = 58;
            this.txtHeight.UseSelectable = true;
            this.txtHeight.WaterMark = "Введите Рост";
            this.txtHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // txtExc
            // 
            // 
            // 
            // 
            this.txtExc.CustomButton.Image = null;
            this.txtExc.CustomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtExc.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtExc.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtExc.CustomButton.Name = "";
            this.txtExc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtExc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExc.CustomButton.TabIndex = 1;
            this.txtExc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExc.CustomButton.UseSelectable = true;
            this.txtExc.CustomButton.Visible = false;
            this.txtExc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtExc.Lines = new string[0];
            this.txtExc.Location = new System.Drawing.Point(523, 106);
            this.txtExc.Margin = new System.Windows.Forms.Padding(2);
            this.txtExc.MaxLength = 32767;
            this.txtExc.Name = "txtExc";
            this.txtExc.PasswordChar = '\0';
            this.txtExc.WaterMark = "Введите Экскурсию";
            this.txtExc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExc.SelectedText = "";
            this.txtExc.SelectionLength = 0;
            this.txtExc.SelectionStart = 0;
            this.txtExc.ShortcutsEnabled = true;
            this.txtExc.Size = new System.Drawing.Size(137, 28);
            this.txtExc.TabIndex = 57;
            this.txtExc.UseSelectable = true;
            this.txtExc.WaterMark = "Введите Экскурсию";
            this.txtExc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(411, 105);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(108, 25);
            this.metroLabel10.TabIndex = 56;
            this.metroLabel10.Text = "Экскурсия:";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(464, 45);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(55, 25);
            this.metroLabel11.TabIndex = 55;
            this.metroLabel11.Text = "Рост:";
            this.metroLabel11.UseStyleColors = true;
            // 
            // btnReg
            // 
            this.btnReg.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnReg.Location = new System.Drawing.Point(27, 354);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(746, 28);
            this.btnReg.TabIndex = 48;
            this.btnReg.Text = "Завершить регистрацию";
            this.btnReg.UseSelectable = true;
            this.btnReg.UseStyleColors = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 412);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnReg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.Resizable = false;
            this.Text = "Регистрация";
            this.tabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion        

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroRadioButton rnW;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroRadioButton rbMen;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime dtpDateBirthday;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPatronymic;
        private MetroFramework.Controls.MetroTextBox txtSurname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnReg;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox txtDin;
        private MetroFramework.Controls.MetroTextBox txtWeight;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtHeight;
        private MetroFramework.Controls.MetroTextBox txtExc;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox cmbLevel;
    }
}