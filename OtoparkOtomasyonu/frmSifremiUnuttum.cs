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
using System.Net;
using System.Net.Mail;

namespace OtoparkOtomasyonu
{
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        SqlBaglanti baglan = new SqlBaglanti();

        void guncelle()
        {
            SqlCommand komut = new SqlCommand("Select *from tblKullanicilar where KullanıcıAdı=@p1 AND TC=@p2", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand komut2 = new SqlCommand("Update tblKullanicilar set Şifre='" + txtSifre.Text +
                    "'where KullanıcıAdı='" + txtKullaniciAdi.Text + "'", baglan.sqlbaglan());
                komut2.ExecuteNonQuery();
                MessageBox.Show("Şifreniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!\nLütfen kontrol ediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglan.sqlbaglan().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text) MessageBox.Show("Şifreler uyuşmuyor.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else guncelle();
        }

        private void btnGosterGizle_Click(object sender, EventArgs e)
        {
            if (txtSifreTekrar.Properties.PasswordChar == '*')
            {
                txtSifreTekrar.Properties.PasswordChar = '\0';
                btnGosterGizle.Text = "Gizle";
            }
            else
            {
                txtSifreTekrar.Properties.PasswordChar = '*';
                btnGosterGizle.Text = "Göster";
            }
        }

        private void btnGizleGoster_Click(object sender, EventArgs e)
        {
            if (txtSifre.Properties.PasswordChar == '*')
            {
                txtSifre.Properties.PasswordChar = '\0';
                btnGizleGoster.Text = "Gizle";
            }
            else
            {
                txtSifre.Properties.PasswordChar = '*';
                btnGizleGoster.Text = "Göster";
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmKilitEkrani frmke = new frmKilitEkrani();
            frmke.Show();
            this.Hide();
        }

        

        
    }
}
