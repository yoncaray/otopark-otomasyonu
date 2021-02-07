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
    public partial class frmHizliErisim : Form
    {
        public frmHizliErisim()
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
        frmKullaniciEkleSil frmkes;

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmn == null || frmn.IsDisposed)
            {
                frmn = new frmNotlar();
                frmn.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();               
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
            }
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmog == null || frmog.IsDisposed)
            {
                frmog = new frmOtoparkGiris();
                frmog.Show();
                if (frmn != null) frmn.Close();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmoc == null || frmoc.IsDisposed)
            {
                frmoc = new frmOtoparkCikis();
                frmoc.Show();
                if (frmog != null) frmog.Close();
                if (frmn != null) frmn.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmoy == null || frmoy.IsDisposed)
            {
                frmoy = new frmOtoparkYerleri();
                frmoy.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();
                if (frmn != null) frmn.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmmk == null || frmmk.IsDisposed)
            {
                frmmk = new frmMusteriKayitlari();
                frmmk.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmn != null) frmn.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmg == null || frmg.IsDisposed)
            {
                frmg = new frmGiderler();
                frmg.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
                if (frmn != null) frmn.Close();
                if (frmkz != null) frmkz.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmkz == null || frmkz.IsDisposed)
            {
                frmkz = new frmKarZarar();
                frmkz.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
                if (frmg != null) frmg.Close();
                if (frmn != null) frmn.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmr == null || frmr.IsDisposed)
            {
                frmr = new frmRadyo();
                frmr.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmn != null) frmn.Close();
                if (frmke != null) frmke.Close();
                if (frmsu != null) frmsu.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmkes == null || frmkes.IsDisposed)
            {
                frmkes = new frmKullaniciEkleSil();
                frmkes.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmn != null) frmn.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
                if (frmsu != null) frmsu.Close();
            }
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmke == null || frmke.IsDisposed)
            {
                frmke = new frmKilitEkrani();
                frmke.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmn != null) frmn.Close();
                if (frmsu != null) frmsu.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmsu == null || frmsu.IsDisposed)
            {
                frmsu = new frmSifremiUnuttum();
                frmsu.Show();
                if (frmog != null) frmog.Close();
                if (frmoc != null) frmoc.Close();
                if (frmoy != null) frmoy.Close();
                if (frmmk != null) frmmk.Close();
                if (frmr != null) frmr.Close();
                if (frmke != null) frmke.Close();
                if (frmn != null) frmn.Close();
                if (frmg != null) frmg.Close();
                if (frmkz != null) frmkz.Close();
                if (frmkes != null) frmkes.Close();
            }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Application.Exit();
        }

    }
}
