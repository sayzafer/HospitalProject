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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //datagride doktorlari cekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_doctors", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //branslari comboboxa cekme
            SqlCommand komut2 = new SqlCommand("select branchName from Tbl_branches", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                txtBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_doctors (doctorName,doctorLastName,doctorBranch,doktorTC,doctorPsw) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("p2", txtLastName.Text);
            komut.Parameters.AddWithValue("@p3", txtBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtTC.Text);
            komut.Parameters.AddWithValue("@p5", txtPsw.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPsw.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_doctors where doktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silidi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_doctors set doctorName=@p1,doctorLastName=@p2,doctorBranch=@p3,doctorPsw=@p5 where doktorTC=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("p2", txtLastName.Text);
            komut.Parameters.AddWithValue("@p3", txtBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtTC.Text);
            komut.Parameters.AddWithValue("@p5", txtPsw.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
