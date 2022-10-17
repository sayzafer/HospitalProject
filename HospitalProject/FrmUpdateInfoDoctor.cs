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
    public partial class FrmUpdateInfoDoctor : Form
    {
        public FrmUpdateInfoDoctor()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;

        private void FrmUpdateInfoDoctor_Load(object sender, EventArgs e)
        {
            txtTC.Text = tc;


            SqlCommand komut = new SqlCommand("select * from Tbl_doctors where doktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtLastName.Text = dr[2].ToString();
                txtBrans.Text = dr[3].ToString();
                txtPsw.Text = dr[5].ToString();
                bgl.baglanti().Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_doctors set doctorName=@p1,doctorLastName=@p2,doctorBranch=@p3,doctorPsw=@p4 where doktorTc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtLastName.Text);
            komut.Parameters.AddWithValue("@p3", txtBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtPsw.Text);
            komut.Parameters.AddWithValue("@p5", txtTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi!");
        }
    }
}
