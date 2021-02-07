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
    public partial class frmKilitEkrani : Form
    {
        public frmKilitEkrani()
        {
            InitializeComponent();
        }      

        SqlBaglanti baglan = new SqlBaglanti();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *from tblKullanicilar where KullanıcıAdı=@p1 AND Şifre=@p2", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmOtoparkOtomasyonu frmoo = new frmOtoparkOtomasyonu();
                frmoo.kullaniciAdi = txtKullaniciAdi.Text;
                frmoo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre uyuşmuyor!\nLütfen kontrol ediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglan.sqlbaglan().Close();
        }

        private void lnkSifremiUnuttum_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum frmsu = new frmSifremiUnuttum();
            frmsu.Show();
            this.Hide();
        }

        private void btnGosterGizle_Click(object sender, EventArgs e)
        {
            if (txtSifre.Properties.PasswordChar == '*')
            {
                txtSifre.Properties.PasswordChar = '\0';
                btnGosterGizle.Text = "Gizle";
            }
            else
            {
                txtSifre.Properties.PasswordChar = '*';
                btnGosterGizle.Text = "Göster";
            }
        }
    }
}
