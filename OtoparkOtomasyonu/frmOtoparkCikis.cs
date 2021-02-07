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
    public partial class frmOtoparkCikis : Form
    {
        public frmOtoparkCikis()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        void plakaGoster()
        {
            SqlCommand komut = new SqlCommand("Select *from tblMusteriKayitlari", baglan.sqlbaglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Tutar"].ToString() == "") cmbPlaka.Properties.Items.Add(dr["Plaka"].ToString());
            }
            baglan.sqlbaglan().Close();
        }

        void temizle()
        {
            cmbPlaka.Text = "";
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";
            txtPlaka.Text = "";
            txtParkYeri.Text = "";
            txtGirisTarihi.Text = "";
            txtCikisTarihi.Text = "";
            txtSure.Text = "";
            txtTutar.Text = "";
            cmbPlaka.Properties.Items.Clear();
        }

        private void frmOtoparkCikis_Load(object sender, EventArgs e)
        {
            plakaGoster();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *from tblMusteriKayitlari where Plaka='" + cmbPlaka.SelectedItem + "'", baglan.sqlbaglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAdSoyad.Text = dr["AdSoyad"].ToString();
                txtTelefon.Text = dr["Telefon"].ToString();
                txtPlaka.Text = dr["Plaka"].ToString();
                txtParkYeri.Text = dr["ParkYeri"].ToString();
                txtGirisTarihi.Text = dr["GirişTarihi"].ToString();
                lblID.Text = dr["ID"].ToString();
            }
            baglan.sqlbaglan().Close();
            DateTime giris, cikis;
            giris = DateTime.Parse(txtGirisTarihi.Text);
            cikis = DateTime.Parse(txtCikisTarihi.Text);
            TimeSpan fark;
            fark = cikis - giris;
            txtSure.Text = fark.TotalHours.ToString("0.00");
            if (double.Parse(txtSure.Text) < 1) txtTutar.Text = (1 * 3).ToString("0.00");
            else txtTutar.Text = (double.Parse(txtSure.Text) * 3).ToString("0.00");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tblMusteriKayitlari set ÇıkışTarihi=@p1,Tutar=@p2 where ID=@p3", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtCikisTarihi.Text);
            komut.Parameters.AddWithValue("@p2", SqlDbType.Decimal).Value = decimal.Parse(txtTutar.Text);
            komut.Parameters.AddWithValue("@p3", lblID.Text);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("Update tblParkYeriDurumu set Durum='False' where ParkYeri='" + txtParkYeri.Text + "'", baglan.sqlbaglan());
            komut2.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Çıkış işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            plakaGoster();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            temizle();
            MessageBox.Show("İşleminiz iptal edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            plakaGoster();
        }
    }
}
