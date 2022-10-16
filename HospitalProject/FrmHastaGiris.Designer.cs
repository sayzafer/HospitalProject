namespace HospitalProject
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.linkSignin = new System.Windows.Forms.LinkLabel();
            this.patientTC = new System.Windows.Forms.MaskedTextBox();
            this.patientPsw = new System.Windows.Forms.TextBox();
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(168, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // linkSignin
            // 
            this.linkSignin.AutoSize = true;
            this.linkSignin.Location = new System.Drawing.Point(274, 303);
            this.linkSignin.Name = "linkSignin";
            this.linkSignin.Size = new System.Drawing.Size(77, 24);
            this.linkSignin.TabIndex = 1;
            this.linkSignin.TabStop = true;
            this.linkSignin.Text = "Kayıt Ol";
            this.linkSignin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignin_LinkClicked);
            // 
            // patientTC
            // 
            this.patientTC.Location = new System.Drawing.Point(236, 144);
            this.patientTC.Mask = "00000000000";
            this.patientTC.Name = "patientTC";
            this.patientTC.Size = new System.Drawing.Size(160, 32);
            this.patientTC.TabIndex = 2;
            this.patientTC.ValidatingType = typeof(int);
            // 
            // patientPsw
            // 
            this.patientPsw.Location = new System.Drawing.Point(236, 193);
            this.patientPsw.Name = "patientPsw";
            this.patientPsw.Size = new System.Drawing.Size(160, 32);
            this.patientPsw.TabIndex = 3;
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.Location = new System.Drawing.Point(253, 245);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(112, 38);
            this.btnPatientLogin.TabIndex = 4;
            this.btnPatientLogin.Text = "Giriş Yap";
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btnPatientLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(636, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPatientLogin);
            this.Controls.Add(this.patientPsw);
            this.Controls.Add(this.patientTC);
            this.Controls.Add(this.linkSignin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkSignin;
        private System.Windows.Forms.MaskedTextBox patientTC;
        private System.Windows.Forms.TextBox patientPsw;
        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}