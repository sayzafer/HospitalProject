namespace HospitalProject
{
    partial class SekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDuyuru = new System.Windows.Forms.RichTextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaat = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrans = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDoktor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnRandevuList = new System.Windows.Forms.Button();
            this.btnBransPanel = new System.Windows.Forms.Button();
            this.btnDoktorPanel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(140, 56);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 24);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "00000000000";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(140, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Null Null";
            this.lblName.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Controls.Add(this.txtDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(26, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // txtDuyuru
            // 
            this.txtDuyuru.Location = new System.Drawing.Point(16, 40);
            this.txtDuyuru.Name = "txtDuyuru";
            this.txtDuyuru.Size = new System.Drawing.Size(317, 214);
            this.txtDuyuru.TabIndex = 0;
            this.txtDuyuru.Text = "";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(52, 272);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(242, 48);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.txtTC);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDoktor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtBrans);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSaat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTarih);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(411, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 525);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(179, 32);
            this.txtID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tarih:";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(124, 109);
            this.txtTarih.Mask = "00/00/0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(179, 32);
            this.txtTarih.TabIndex = 3;
            this.txtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Saat:";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(124, 168);
            this.txtSaat.Mask = "00:00";
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(179, 32);
            this.txtSaat.TabIndex = 5;
            this.txtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Branş:";
            // 
            // txtBrans
            // 
            this.txtBrans.FormattingEnabled = true;
            this.txtBrans.Location = new System.Drawing.Point(124, 228);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(179, 32);
            this.txtBrans.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Doktor:";
            // 
            // txtDoktor
            // 
            this.txtDoktor.FormattingEnabled = true;
            this.txtDoktor.Location = new System.Drawing.Point(124, 283);
            this.txtDoktor.Name = "txtDoktor";
            this.txtDoktor.Size = new System.Drawing.Size(179, 32);
            this.txtDoktor.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "TC:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(124, 340);
            this.txtTC.Mask = "00000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(179, 32);
            this.txtTC.TabIndex = 11;
            this.txtTC.ValidatingType = typeof(int);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(124, 412);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(179, 48);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 48);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(772, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(398, 285);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(773, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(397, 353);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDoktorPanel);
            this.groupBox6.Controls.Add(this.btnBransPanel);
            this.groupBox6.Controls.Add(this.btnRandevuList);
            this.groupBox6.Location = new System.Drawing.Point(28, 566);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(731, 96);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(391, 322);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnRandevuList
            // 
            this.btnRandevuList.Location = new System.Drawing.Point(483, 41);
            this.btnRandevuList.Name = "btnRandevuList";
            this.btnRandevuList.Size = new System.Drawing.Size(203, 35);
            this.btnRandevuList.TabIndex = 15;
            this.btnRandevuList.Text = "Randevu Listele";
            this.btnRandevuList.UseVisualStyleBackColor = true;
            // 
            // btnBransPanel
            // 
            this.btnBransPanel.Location = new System.Drawing.Point(254, 41);
            this.btnBransPanel.Name = "btnBransPanel";
            this.btnBransPanel.Size = new System.Drawing.Size(203, 35);
            this.btnBransPanel.TabIndex = 16;
            this.btnBransPanel.Text = "Branş Paneli";
            this.btnBransPanel.UseVisualStyleBackColor = true;
            // 
            // btnDoktorPanel
            // 
            this.btnDoktorPanel.Location = new System.Drawing.Point(40, 41);
            this.btnDoktorPanel.Name = "btnDoktorPanel";
            this.btnDoktorPanel.Size = new System.Drawing.Size(203, 35);
            this.btnDoktorPanel.TabIndex = 17;
            this.btnDoktorPanel.Text = " Doktor Paneli";
            this.btnDoktorPanel.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(124, 378);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 28);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Durum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1183, 675);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SekreterDetay";
            this.Text = " Sekreter Detay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.RichTextBox txtDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox txtTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtDoktor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtBrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtSaat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDoktorPanel;
        private System.Windows.Forms.Button btnBransPanel;
        private System.Windows.Forms.Button btnRandevuList;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}