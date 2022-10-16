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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            //Ad Soyad cekme
            SqlCommand komut = new SqlCommand("select patientName,patientLastName from Tbl_patients where patientTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();


            //Randevu gecmisi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where hastaTC="+tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Branslari cekme
            SqlCommand komut2 = new SqlCommand("select branchName from Tbl_branches", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                txtbranches.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();



        }

        private void txtbranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdoctors.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doctorName,doctorLastName from Tbl_doctors where doctorBranch=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtbranches.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                txtdoctors.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }



    }
}
