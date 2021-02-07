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
    public partial class frmOtoparkGiris : Form
    {
        public frmOtoparkGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        void parkYeriGoster()
        {
            SqlCommand komut = new SqlCommand("Select *from tblParkYeriDurumu where Durum='False'", baglan.sqlbaglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbParkYeri.Properties.Items.Add(dr["ParkYeri"].ToString());
            }
            baglan.sqlbaglan().Close();
        }

        void temizle()
        {
            txtAdSoyad.Text = "";
            mskTelefon.Text = "";
            txtPlaka.Text = "";
            cmbParkYeri.Text = "";
            cmbParkYeri.Properties.Items.Clear();
        }

        private void frmOtoparkGiris_Load(object sender, EventArgs e)
        {
            parkYeriGoster();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtGirisTarihi.Text = DateTime.Now.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into tblMusteriKayitlari " +
                "(AdSoyad,Telefon,Plaka,ParkYeri,GirişTarihi) values (@p1,@p2,@p3,@p4,@p5)", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p3", txtPlaka.Text);
            komut.Parameters.AddWithValue("@p4", cmbParkYeri.Text);
            komut.Parameters.AddWithValue("@p5", txtGirisTarihi.Text);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("Update tblParkYeriDurumu set Durum='True' where ParkYeri='" + cmbParkYeri.SelectedItem + "'", baglan.sqlbaglan());
            komut2.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Müşteri kaydı başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            parkYeriGoster();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            temizle();
            MessageBox.Show("İşleminiz iptal edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            parkYeriGoster();
        }
    }
}
