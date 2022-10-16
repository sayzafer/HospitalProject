using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalProject
{
    public partial class FrmUpdateInfoPatient : Form
    {
        public FrmUpdateInfoPatient()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string TCno;

        private void FrmUpdateInfoPatient_Load(object sender, EventArgs e)
        {
            txtTC.Text = TCno;
            SqlCommand komut = new SqlCommand("select * from Tbl_patients where patientTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtLastName.Text = dr[2].ToString();
                txtTel.Text = dr[4].ToString();
                txtPsw.Text = dr[5].ToString();
                txtGender.Text = dr[6].ToString();
                bgl.baglanti().Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_patients set patientName=@p1,patientLastName=@p2,patientTel=@p3,patientPsw=@p4,patientGender=@p5 where patientTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtName.Text);
            komut2.Parameters.AddWithValue("@p2", txtLastName.Text);
            komut2.Parameters.AddWithValue("@p3", txtTel.Text);
            komut2.Parameters.AddWithValue("@p4", txtPsw.Text);
            komut2.Parameters.AddWithValue("@p5", txtGender.Text);
            komut2.Parameters.AddWithValue("@p6", txtTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
