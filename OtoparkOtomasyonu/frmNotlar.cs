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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from tblNotlar", baglan.sqlbaglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtID.Text = "";
            txtBaslik.Text = "";
            txtNot.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into tblNotlar (Başlık,Notlar,Tarih) values (@p1,@p2,@p3)", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p2", txtNot.Text);
            komut.Parameters.AddWithValue("@p3", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Kaydetme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tblNotlar set Başlık=@p1,Notlar=@p2,Tarih=@p3 where ID=@p4", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p2", txtNot.Text);
            komut.Parameters.AddWithValue("@p3", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@p4", txtID.Text);
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tblNotlar where ID='" + txtID.Text + "'", baglan.sqlbaglan());
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtBaslik.Text = dr["Başlık"].ToString();
                txtNot.Text = dr["Notlar"].ToString();
            }
        }

        private void frmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
    }
}
