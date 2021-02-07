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
    public partial class frmKarZarar : Form
    {
        public frmKarZarar()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();
        void toplamGider()
        {
            SqlCommand komut = new SqlCommand("Select sum(Tutar) as Tutar from tblGiderler", baglan.sqlbaglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtToplamGider.Text = dr["Tutar"].ToString();
            }
            baglan.sqlbaglan().Close();
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

        double gelir, gider, net;

        void karZarar()
        {
            gelir = double.Parse(txtToplamGelir.Text);
            gider = double.Parse(txtToplamGider.Text);
            net = gelir - gider;
            txtNet.Text = net.ToString();
            if (net < 0) 
            {
                txtSonuc.BackColor = Color.Red;
                double zarar = -net * 100 / gider;
                txtSonuc.Text = "%" + zarar.ToString("0.00") + " Zarar";
            }
            else
            {
                txtSonuc.BackColor = Color.LimeGreen;
                double kar = net * 100 /  gider;
                txtSonuc.Text = "%" + kar.ToString("0.00") + " Kar";
            }
        }

        private void frmKarZarar_Load(object sender, EventArgs e)
        {
            toplamGider();
            toplamGelir();
            karZarar();
            chartControl1.Series["Series 1"].Points.AddPoint("Gelir", gelir);
            chartControl1.Series["Series 1"].Points.AddPoint("Gider", gider);
            chartControl1.Series["Series 1"].Points[1].Color = Color.Red;
        }
    }
}
