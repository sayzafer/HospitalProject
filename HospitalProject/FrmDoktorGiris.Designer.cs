﻿namespace HospitalProject
{
    partial class FrmDoktorGiris
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patientLogin = new System.Windows.Forms.Button();
            this.patientPsw = new System.Windows.Forms.TextBox();
            this.patientTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC:";
            // 
            // patientLogin
            // 
            this.patientLogin.Location = new System.Drawing.Point(255, 227);
            this.patientLogin.Name = "patientLogin";
            this.patientLogin.Size = new System.Drawing.Size(112, 38);
            this.patientLogin.TabIndex = 11;
            this.patientLogin.Text = "Giriş Yap";
            this.patientLogin.UseVisualStyleBackColor = true;
            // 
            // patientPsw
            // 
            this.patientPsw.Location = new System.Drawing.Point(212, 177);
            this.patientPsw.Name = "patientPsw";
            this.patientPsw.Size = new System.Drawing.Size(199, 32);
            this.patientPsw.TabIndex = 10;
            // 
            // patientTC
            // 
            this.patientTC.Location = new System.Drawing.Point(212, 128);
            this.patientTC.Mask = "00000000000";
            this.patientTC.Name = "patientTC";
            this.patientTC.Size = new System.Drawing.Size(199, 32);
            this.patientTC.TabIndex = 9;
            this.patientTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(587, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientLogin);
            this.Controls.Add(this.patientPsw);
            this.Controls.Add(this.patientTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDoktorGiris";
            this.Text = "FrmDoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button patientLogin;
        private System.Windows.Forms.TextBox patientPsw;
        private System.Windows.Forms.MaskedTextBox patientTC;
        private System.Windows.Forms.Label label1;
    }
}