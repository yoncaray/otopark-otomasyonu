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

namespace OtoparkOtomasyonu
{
    public partial class frmKullaniciEkleSil : Form
    {
        public frmKullaniciEkleSil()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from tblKullanicilar", baglan.sqlbaglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtID.Text = "";
            txtAdSoyad.Text = "";           
            txtTC.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
        }

        void kaydet()
        {
            SqlCommand komut = new SqlCommand("Insert into tblKullanicilar (AdSoyad,TC,KullanıcıAdı,Şifre) values (@p1,@p2,@p3,@p4)", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtTC.Text);
            komut.Parameters.AddWithValue("@p3", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Kaydetme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAdSoyad.Text = dr["AdSoyad"].ToString();
                txtTC.Text = dr["TC"].ToString();
                txtKullaniciAdi.Text = dr["KullanıcıAdı"].ToString();
                txtSifre.Text = dr["Şifre"].ToString();
            }
        }

        private void frmKullaniciEkleSil_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text) MessageBox.Show("Şifreler uyuşmuyor.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                kaydet();
                listele();
                temizle();
            }
                
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tblKullanicilar where ID='" + txtID.Text + "'", baglan.sqlbaglan());
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }
    }
}
