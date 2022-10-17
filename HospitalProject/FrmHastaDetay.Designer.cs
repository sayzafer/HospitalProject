namespace HospitalProject
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkUpdateInfo = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.txtsikayet = new System.Windows.Forms.RichTextBox();
            this.txtdoctors = new System.Windows.Forms.ComboBox();
            this.txtbranches = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkUpdateInfo);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bİlgi";
            // 
            // linkUpdateInfo
            // 
            this.linkUpdateInfo.Location = new System.Drawing.Point(18, 141);
            this.linkUpdateInfo.Name = "linkUpdateInfo";
            this.linkUpdateInfo.Size = new System.Drawing.Size(151, 24);
            this.linkUpdateInfo.TabIndex = 5;
            this.linkUpdateInfo.TabStop = true;
            this.linkUpdateInfo.Text = "Bilgileri Güncelle";
            this.linkUpdateInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdateInfo_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(132, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Null Null";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(132, 49);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 24);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRandevuAl);
            this.groupBox2.Controls.Add(this.txtsikayet);
            this.groupBox2.Controls.Add(this.txtdoctors);
            this.groupBox2.Controls.Add(this.txtbranches);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 403);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(142, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(189, 32);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(172, 322);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(121, 33);
            this.btnRandevuAl.TabIndex = 5;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // txtsikayet
            // 
            this.txtsikayet.Location = new System.Drawing.Point(142, 208);
            this.txtsikayet.Name = "txtsikayet";
            this.txtsikayet.Size = new System.Drawing.Size(189, 96);
            this.txtsikayet.TabIndex = 4;
            this.txtsikayet.Text = "";
            this.txtsikayet.TextChanged += new System.EventHandler(this.txtsikayet_TextChanged);
            // 
            // txtdoctors
            // 
            this.txtdoctors.FormattingEnabled = true;
            this.txtdoctors.Location = new System.Drawing.Point(142, 156);
            this.txtdoctors.Name = "txtdoctors";
            this.txtdoctors.Size = new System.Drawing.Size(189, 32);
            this.txtdoctors.TabIndex = 3;
            this.txtdoctors.SelectedIndexChanged += new System.EventHandler(this.txtdoctors_SelectedIndexChanged);
            // 
            // txtbranches
            // 
            this.txtbranches.FormattingEnabled = true;
            this.txtbranches.Location = new System.Drawing.Point(142, 103);
            this.txtbranches.Name = "txtbranches";
            this.txtbranches.Size = new System.Drawing.Size(189, 32);
            this.txtbranches.TabIndex = 2;
            this.txtbranches.SelectedIndexChanged += new System.EventHandler(this.txtbranches_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şikayet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Branş:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(389, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 300);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geçmiş Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(706, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(389, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(712, 300);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(706, 269);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1113, 675);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.RichTextBox txtsikayet;
        private System.Windows.Forms.ComboBox txtdoctors;
        private System.Windows.Forms.ComboBox txtbranches;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkUpdateInfo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
    }
}