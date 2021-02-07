using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class frmOtoparkOtomasyonu : Form
    {
        public frmOtoparkOtomasyonu()
        {
            InitializeComponent();
        }

        frmOtoparkGiris frmog;
        frmOtoparkCikis frmoc;
        frmOtoparkYerleri frmoy;
        frmMusteriKayitlari frmmk;
        frmRadyo frmr;
        frmKilitEkrani frmke;
        frmSifremiUnuttum frmsu;
        frmNotlar frmn;
        frmGiderler frmg;
        frmKarZarar frmkz;
        frmHizliErisim frmhe;
        frmKullaniciEkleSil frmkes;
        public string kullaniciAdi;

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmn == null || frmn.IsDisposed)
            {
                frmn = new frmNotlar();
                frmn.MdiParent = this;
                frmn.Show();
            }
        }

        private void btnOtoparkGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmog == null || frmog.IsDisposed)
            {
                frmog = new frmOtoparkGiris();
                frmog.MdiParent = this;
                frmog.Show();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
            }
        }

        private void btnOtoparkCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmoc == null || frmoc.IsDisposed)
            {
                frmoc = new frmOtoparkCikis();
                frmoc.MdiParent = this;
                frmoc.Show();
                if (frmog != null) frmog.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
            }
        }

        private void btnOtoparkYerleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmoy == null || frmoy.IsDisposed)
            {
                frmoy = new frmOtoparkYerleri();
                frmoy.MdiParent = this;
                frmoy.Show();
                if (frmoc != null) frmoc.Close();
                if (frmog != null) frmog.Close();
                if (frmmk != null) frmmk.Close();
            }
        }

        private void btnMusteriKayitlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmmk == null || frmmk.IsDisposed)
            {
                frmmk = new frmMusteriKayitlari();
                frmmk.MdiParent = this;
                frmmk.Show();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmog != null) frmog.Close();
            }
        }

        private void btnGiderKayitlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmg == null || frmg.IsDisposed)
            {
                frmg = new frmGiderler();
                frmg.MdiParent = this;
                frmg.Show();
                if (frmkz != null) frmkz.Close();
            }
        }

        private void btnKarZarar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmkz == null || frmkz.IsDisposed)
            {
                frmkz = new frmKarZarar();
                frmkz.MdiParent = this;
                frmkz.Show();
                if (frmoc != null) frmoc.Close();
                if (frmg != null) frmg.Close();
            }
        }

        private void btnRadyo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmr == null || frmr.IsDisposed)
            {
                frmr = new frmRadyo();
                frmr.MdiParent = this;
                frmr.Show();
            }
        }

        private void btnKilitEkrani_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmke == null || frmke.IsDisposed)
            {
                frmke = new frmKilitEkrani();
                frmke.Show();
            }
        }

        private void btnSifreGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmsu == null || frmsu.IsDisposed)
            {
                if (frmke != null) frmke.Close();
                if (frmkes != null) frmkes.Close();
                frmsu = new frmSifremiUnuttum();
                frmsu.Show();               
            }
        }

        private void btnKullaniciEkleSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmkes == null || frmkes.IsDisposed)
            {
                frmkes = new frmKullaniciEkleSil();
                frmkes.MdiParent = this;
                frmkes.Show();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
            }
        }

        private void btnProgramiKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void frmOtoparkOtomasyonu_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = kullaniciAdi;
            timer1.Enabled = true;
            frmhe = new frmHizliErisim();
            frmhe.MdiParent = this;
            frmhe.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToShortTimeString();
            labelTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnHizliErisim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmhe == null || frmhe.IsDisposed)
            {
                frmhe = new frmHizliErisim();
                frmhe.MdiParent = this;
                frmhe.Show();
            }
        }

        
    }
}
