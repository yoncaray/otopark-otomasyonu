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
    public partial class frmOtoparkYerleri : Form
    {
        public frmOtoparkYerleri()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();       

        void parkYeriDurumu()
        {
            SqlCommand komut = new SqlCommand("Select *from tblParkYeriDurumu", baglan.sqlbaglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.panelControl1.Controls)
                {
                    if(item is Button)
                    {
                        if (item.Text == dr[0].ToString() && dr[1].ToString() == "True") 
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            SqlCommand komut2 = new SqlCommand("Select *from tblMusteriKayitlari", baglan.sqlbaglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                foreach (Control item in this.panelControl1.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == dr2["ParkYeri"].ToString() && dr2["Tutar"].ToString() == "")  
                        {
                            item.Text = dr2["Plaka"].ToString();
                        }
                    }
                }
            }
            baglan.sqlbaglan().Close();
        }

        private void frmOtoparkYerleri_Load(object sender, EventArgs e)
        {
            parkYeriDurumu();
        }



    }
}
