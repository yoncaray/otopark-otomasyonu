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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from tblGiderler", baglan.sqlbaglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtID.Text = "";
            txtGiderAd.Text = "";
            txtTutar.Text = "";
        }

        void toplamGider()
        {
            SqlCommand komut = new SqlCommand("Select sum(Tutar) as toplamGider from tblGiderler", baglan.sqlbaglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtToplamTutar.Text = dr["toplamGider"].ToString();
            }
            baglan.sqlbaglan().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into tblGiderler (GiderAd,Tutar,Tarih) values (@p1,@p2,@p3)", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtGiderAd.Text);
            komut.Parameters.AddWithValue("@p2", txtTutar.Text);
            komut.Parameters.AddWithValue("@p3", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Kaydetme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
            toplamGider();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tblGiderler set GiderAd=@p1,Tutar=@p2,Tarih=@p3 where ID=@p4", baglan.sqlbaglan());
            komut.Parameters.AddWithValue("@p1", txtGiderAd.Text);
            komut.Parameters.AddWithValue("@p2", SqlDbType.Decimal).Value = decimal.Parse(txtTutar.Text);
            komut.Parameters.AddWithValue("@p3", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@p4", txtID.Text);
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
            toplamGider();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tblGiderler where ID='" + txtID.Text + "'", baglan.sqlbaglan());
            komut.ExecuteNonQuery();
            baglan.sqlbaglan().Close();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
            toplamGider();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtGiderAd.Text = dr["GiderAd"].ToString();
                txtTutar.Text = dr["Tutar"].ToString();
            }
        }

        private void frmGiderler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            toplamGider();
        }
    }
}
