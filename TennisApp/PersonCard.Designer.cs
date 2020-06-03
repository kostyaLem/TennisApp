namespace TennisApp
{
    partial class PersonCard
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
            this.btnStartNew = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtTraining = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartNew
            // 
            this.btnStartNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStartNew.Location = new System.Drawing.Point(23, 114);
            this.btnStartNew.Name = "btnStartNew";
            this.btnStartNew.Size = new System.Drawing.Size(278, 37);
            this.btnStartNew.TabIndex = 52;
            this.btnStartNew.Text = "Добавить новые параметры";
            this.btnStartNew.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(393, 114);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(278, 37);
            this.metroButton1.TabIndex = 54;
            this.metroButton1.Text = "Идеальные параметры";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // txtTraining
            // 
            this.txtTraining.AcceptsReturn = true;
            this.txtTraining.AcceptsTab = true;
            this.txtTraining.Location = new System.Drawing.Point(43, 205);
            this.txtTraining.Multiline = true;
            this.txtTraining.Name = "txtTraining";
            this.txtTraining.Size = new System.Drawing.Size(774, 144);
            this.txtTraining.TabIndex = 55;
            this.txtTraining.Text = "Таблица: рост, вес, динанометрия, экскурсия, какойто  индекс, и дата введения пар" +
    "аметров";
            // 
            // PersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 622);
            this.Controls.Add(this.txtTraining);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnStartNew);
            this.Name = "PersonCard";
            this.Text = "Паспорт здоровья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnStartNew;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox txtTraining;
    }
}