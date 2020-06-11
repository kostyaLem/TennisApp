namespace TennisApp
{
    partial class MainForm
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnStartNew = new MetroFramework.Controls.MetroButton();
            this.lblStart = new MetroFramework.Controls.MetroLabel();
            this.lblEnd = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtTraining = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(31, 96);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(407, 44);
            this.metroLabel4.TabIndex = 49;
            this.metroLabel4.Text = "Описание тренировки:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(31, 640);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 25);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "Дата начала:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(233, 640);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 25);
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "Дата конца:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // btnStartNew
            // 
            this.btnStartNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStartNew.Location = new System.Drawing.Point(692, 652);
            this.btnStartNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartNew.Name = "btnStartNew";
            this.btnStartNew.Size = new System.Drawing.Size(371, 46);
            this.btnStartNew.TabIndex = 51;
            this.btnStartNew.Text = "Начать новую тренировку";
            this.btnStartNew.UseSelectable = true;
            this.btnStartNew.Click += new System.EventHandler(this.btnStartNew_Click);
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStart.AutoSize = true;
            this.lblStart.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStart.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStart.Location = new System.Drawing.Point(31, 671);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(110, 25);
            this.lblStart.TabIndex = 51;
            this.lblStart.Text = "01.04.2020";
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Lime;
            this.lblEnd.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEnd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEnd.Location = new System.Drawing.Point(233, 671);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(110, 25);
            this.lblEnd.TabIndex = 52;
            this.lblEnd.Text = "22.09.2021";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(692, 78);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(371, 46);
            this.metroButton1.TabIndex = 53;
            this.metroButton1.Text = "Паспорт здоровья";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // txtTraining
            // 
            this.txtTraining.AcceptsReturn = true;
            this.txtTraining.AcceptsTab = true;
            this.txtTraining.Location = new System.Drawing.Point(31, 144);
            this.txtTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTraining.Multiline = true;
            this.txtTraining.Name = "txtTraining";
            this.txtTraining.ReadOnly = true;
            this.txtTraining.Size = new System.Drawing.Size(1031, 491);
            this.txtTraining.TabIndex = 54;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 726);
            this.Controls.Add(this.txtTraining);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnStartNew);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1093, 726);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Тренировка:";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnStartNew;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblEnd;
        private MetroFramework.Controls.MetroLabel lblStart;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox txtTraining;
    }
}