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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void patientLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_doctors where doktorTc=@p1 and doctorPsw=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTC.Text);
            komut.Parameters.AddWithValue("@p2", txtPsw.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.tc = txtTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc ya da şifre!");
            }
            bgl.baglanti().Close();
        }
    }
}
