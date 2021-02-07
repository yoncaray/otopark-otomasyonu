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
    public partial class frmMusteriKayitlari : Form
    {
        public frmMusteriKayitlari()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from tblMusteriKayitlari", baglan.sqlbaglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtID.Text = "";
            txtAdSoyad.Text = "";
            mskTelefon.Text = "";
            txtPlaka.Text = "";
            txtParkYeri.Text = "";
            txtGirisTarihi.Text = "";
            txtCikisTarihi.Text = "";
            txtTutar.Text = "";
        }

        void toplamGelir()
        {
            SqlCommand komut = new SqlCommand("Select sum(Tutar) as Tutar from tblMusteriKayitlari", baglan.sqlbaglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtToplamGelir.Text = dr["Tutar"].ToString();
            }
            baglan.sqlbaglan().Close();
        }

        private void frmMusteriKayitlari_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            toplamGelir();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAdSoyad.Text = dr["AdSoyad"].ToString();
                mskTelefon.Text = dr["Telefon"].ToString();
                txtPlaka.Text = dr["Plaka"].ToString();
                txtParkYeri.Text = dr["ParkYeri"].ToString();
                txtGirisTarihi.Text = dr["GirişTarihi"].ToString();
                txtCikisTarihi.Text = dr["ÇıkışTarihi"].ToString();
                txtTutar.Text = dr["Tutar"].ToString();    
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tblMusteriKayitlari set AdSoyad=@p1,Telefon=@p2,Plaka=@p3 where ID=@p4", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p3", txtPlaka.Text);
            komut.Parameters.AddWithValue("@p4", txtID.Text);
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tblMusteriKayitlari where ID='" + txtID.Text + "'", baglan.sqlbaglan());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("Update tblParkYeriDurumu set Durum='False' where ParkYeri='" + txtParkYeri.Text + "'", baglan.sqlbaglan());
            komut2.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            toplamGelir();
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
