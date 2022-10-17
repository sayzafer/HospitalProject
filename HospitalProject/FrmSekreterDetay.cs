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
using System.Net.Http.Headers;

namespace HospitalProject
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCno;

            //Ad Soyad cekme
            SqlCommand komut1 = new SqlCommand("select secName From Tbl_Sec where secTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblName.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();


            //bransları datagride cekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_branches", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //doktorlari datagride cekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doctorName+doctorLastName) from Tbl_doctors", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


            //bransı comboboxa cekme
            SqlCommand komut2 = new SqlCommand("select branchName from Tbl_branches", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                txtBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (randevuTarih,randevuSaat,randevuBranc,randevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", txtTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", txtSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", txtBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", txtDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu!");
        }

        private void txtBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select doctorName,doctorLastName from Tbl_doctors where doctorBranch=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_duyurular (duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            txtDuyuru.Clear();
            MessageBox.Show("Duyuru Oluşturuldu");

        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
        }

        private void btnRandevuList_Click(object sender, EventArgs e)
        {
            FrmRandevuList fr = new FrmRandevuList();
            fr.Show();
        }
    }
}
