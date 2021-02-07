namespace OtoparkOtomasyonu
{
    partial class frmOtoparkOtomasyonu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtoparkOtomasyonu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnOtoparkGiris = new DevExpress.XtraBars.BarButtonItem();
            this.btnOtoparkCikis = new DevExpress.XtraBars.BarButtonItem();
            this.btnOtoparkYerleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriKayitlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderKayitlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnKarZarar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRadyo = new DevExpress.XtraBars.BarButtonItem();
            this.btnKilitEkrani = new DevExpress.XtraBars.BarButtonItem();
            this.btnSifreGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgramiKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnHizliErisim = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.labelSaat = new DevExpress.XtraEditors.LabelControl();
            this.labelTarih = new DevExpress.XtraEditors.LabelControl();
            this.lblKullanici = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnKullaniciEkleSil = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNotlar,
            this.btnOtoparkGiris,
            this.btnOtoparkCikis,
            this.btnOtoparkYerleri,
            this.btnMusteriKayitlari,
            this.btnGiderKayitlari,
            this.btnKarZarar,
            this.btnRadyo,
            this.btnKilitEkrani,
            this.btnSifreGuncelle,
            this.btnProgramiKapat,
            this.btnHizliErisim,
            this.btnKullaniciEkleSil});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbonControl1.Size = new System.Drawing.Size(894, 158);
            // 
            // btnNotlar
            // 
            this.btnNotlar.Caption = "NOTLAR";
            this.btnNotlar.Id = 1;
            this.btnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.Image")));
            this.btnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.LargeImage")));
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotlar_ItemClick);
            // 
            // btnOtoparkGiris
            // 
            this.btnOtoparkGiris.Caption = "OTOPARK GİRİŞ";
            this.btnOtoparkGiris.Id = 2;
            this.btnOtoparkGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOtoparkGiris.ImageOptions.Image")));
            this.btnOtoparkGiris.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOtoparkGiris.ImageOptions.LargeImage")));
            this.btnOtoparkGiris.Name = "btnOtoparkGiris";
            this.btnOtoparkGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOtoparkGiris_ItemClick);
            // 
            // btnOtoparkCikis
            // 
            this.btnOtoparkCikis.Caption = "OTOPARK ÇIKIŞ";
            this.btnOtoparkCikis.Id = 3;
            this.btnOtoparkCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOtoparkCikis.ImageOptions.Image")));
            this.btnOtoparkCikis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOtoparkCikis.ImageOptions.LargeImage")));
            this.btnOtoparkCikis.Name = "btnOtoparkCikis";
            this.btnOtoparkCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOtoparkCikis_ItemClick);
            // 
            // btnOtoparkYerleri
            // 
            this.btnOtoparkYerleri.Caption = "OTOPARK YERLERİ";
            this.btnOtoparkYerleri.Id = 4;
            this.btnOtoparkYerleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOtoparkYerleri.ImageOptions.Image")));
            this.btnOtoparkYerleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOtoparkYerleri.ImageOptions.LargeImage")));
            this.btnOtoparkYerleri.Name = "btnOtoparkYerleri";
            this.btnOtoparkYerleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOtoparkYerleri_ItemClick);
            // 
            // btnMusteriKayitlari
            // 
            this.btnMusteriKayitlari.Caption = "MÜŞTERİ KAYITLARI";
            this.btnMusteriKayitlari.Id = 5;
            this.btnMusteriKayitlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriKayitlari.ImageOptions.Image")));
            this.btnMusteriKayitlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriKayitlari.ImageOptions.LargeImage")));
            this.btnMusteriKayitlari.Name = "btnMusteriKayitlari";
            this.btnMusteriKayitlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriKayitlari_ItemClick);
            // 
            // btnGiderKayitlari
            // 
            this.btnGiderKayitlari.Caption = "GİDER KAYITLARI";
            this.btnGiderKayitlari.Id = 6;
            this.btnGiderKayitlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiderKayitlari.ImageOptions.Image")));
            this.btnGiderKayitlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiderKayitlari.ImageOptions.LargeImage")));
            this.btnGiderKayitlari.Name = "btnGiderKayitlari";
            this.btnGiderKayitlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderKayitlari_ItemClick);
            // 
            // btnKarZarar
            // 
            this.btnKarZarar.Caption = "KAR-ZARAR DURUMU";
            this.btnKarZarar.Id = 7;
            this.btnKarZarar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKarZarar.ImageOptions.Image")));
            this.btnKarZarar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKarZarar.ImageOptions.LargeImage")));
            this.btnKarZarar.Name = "btnKarZarar";
            this.btnKarZarar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKarZarar_ItemClick);
            // 
            // btnRadyo
            // 
            this.btnRadyo.Caption = "RADYO";
            this.btnRadyo.Id = 8;
            this.btnRadyo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRadyo.ImageOptions.Image")));
            this.btnRadyo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRadyo.ImageOptions.LargeImage")));
            this.btnRadyo.Name = "btnRadyo";
            this.btnRadyo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRadyo_ItemClick);
            // 
            // btnKilitEkrani
            // 
            this.btnKilitEkrani.Caption = "KİLİT EKRANI";
            this.btnKilitEkrani.Id = 9;
            this.btnKilitEkrani.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKilitEkrani.ImageOptions.Image")));
            this.btnKilitEkrani.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKilitEkrani.ImageOptions.LargeImage")));
            this.btnKilitEkrani.Name = "btnKilitEkrani";
            this.btnKilitEkrani.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKilitEkrani_ItemClick);
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Caption = "ŞİFRE GÜNCELLE";
            this.btnSifreGuncelle.Id = 10;
            this.btnSifreGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSifreGuncelle.ImageOptions.Image")));
            this.btnSifreGuncelle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSifreGuncelle.ImageOptions.LargeImage")));
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSifreGuncelle_ItemClick);
            // 
            // btnProgramiKapat
            // 
            this.btnProgramiKapat.Caption = "PROGRAMI KAPAT";
            this.btnProgramiKapat.Id = 11;
            this.btnProgramiKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProgramiKapat.ImageOptions.Image")));
            this.btnProgramiKapat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProgramiKapat.ImageOptions.LargeImage")));
            this.btnProgramiKapat.Name = "btnProgramiKapat";
            this.btnProgramiKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProgramiKapat_ItemClick);
            // 
            // btnHizliErisim
            // 
            this.btnHizliErisim.Caption = "HIZLI_ERİŞİM";
            this.btnHizliErisim.Id = 13;
            this.btnHizliErisim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHizliErisim.ImageOptions.Image")));
            this.btnHizliErisim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHizliErisim.ImageOptions.LargeImage")));
            this.btnHizliErisim.Name = "btnHizliErisim";
            this.btnHizliErisim.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnHizliErisim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHizliErisim_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ANA SAYFA";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHizliErisim);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "OTOPARK İŞLEMLERİ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOtoparkGiris);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOtoparkCikis);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOtoparkYerleri);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMusteriKayitlari);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGiderKayitlari);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "İSTATİSTİKLER";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKarZarar);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ribbonPage4.Appearance.Options.UseFont = true;
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "EĞLENCE";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnRadyo);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ribbonPage5.Appearance.Options.UseFont = true;
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.ImageOptions.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "AYARLAR";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKullaniciEkleSil);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKilitEkrani);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnSifreGuncelle);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnProgramiKapat);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // labelSaat
            // 
            this.labelSaat.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelSaat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSaat.Appearance.Options.UseBackColor = true;
            this.labelSaat.Appearance.Options.UseFont = true;
            this.labelSaat.Appearance.Options.UseForeColor = true;
            this.labelSaat.Location = new System.Drawing.Point(847, 39);
            this.labelSaat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(31, 12);
            this.labelSaat.TabIndex = 4;
            this.labelSaat.Text = "00:00";
            // 
            // labelTarih
            // 
            this.labelTarih.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTarih.Appearance.Options.UseBackColor = true;
            this.labelTarih.Appearance.Options.UseFont = true;
            this.labelTarih.Appearance.Options.UseForeColor = true;
            this.labelTarih.Location = new System.Drawing.Point(829, 51);
            this.labelTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(62, 12);
            this.labelTarih.TabIndex = 5;
            this.labelTarih.Text = "00.00.0000";
            // 
            // lblKullanici
            // 
            this.lblKullanici.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblKullanici.Appearance.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanici.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblKullanici.Appearance.Options.UseBackColor = true;
            this.lblKullanici.Appearance.Options.UseFont = true;
            this.lblKullanici.Appearance.Options.UseForeColor = true;
            this.lblKullanici.Location = new System.Drawing.Point(829, 0);
            this.lblKullanici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(69, 13);
            this.lblKullanici.TabIndex = 6;
            this.lblKullanici.Text = "Kullanıcı";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // btnKullaniciEkleSil
            // 
            this.btnKullaniciEkleSil.Caption = "KULLANICI EKLE-SİL";
            this.btnKullaniciEkleSil.Id = 14;
            this.btnKullaniciEkleSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkleSil.ImageOptions.Image")));
            this.btnKullaniciEkleSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkleSil.ImageOptions.LargeImage")));
            this.btnKullaniciEkleSil.Name = "btnKullaniciEkleSil";
            this.btnKullaniciEkleSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciEkleSil_ItemClick);
            // 
            // frmOtoparkOtomasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 611);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.labelSaat);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmOtoparkOtomasyonu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTOPARK OTOMAYONU";
            this.Load += new System.EventHandler(this.frmOtoparkOtomasyonu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnOtoparkGiris;
        private DevExpress.XtraBars.BarButtonItem btnOtoparkCikis;
        private DevExpress.XtraBars.BarButtonItem btnOtoparkYerleri;
        private DevExpress.XtraBars.BarButtonItem btnMusteriKayitlari;
        private DevExpress.XtraBars.BarButtonItem btnGiderKayitlari;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraEditors.LabelControl labelSaat;
        private DevExpress.XtraEditors.LabelControl labelTarih;
        private DevExpress.XtraEditors.LabelControl lblKullanici;
        private DevExpress.XtraBars.BarButtonItem btnKarZarar;
        private DevExpress.XtraBars.BarButtonItem btnRadyo;
        private DevExpress.XtraBars.BarButtonItem btnKilitEkrani;
        private DevExpress.XtraBars.BarButtonItem btnSifreGuncelle;
        private DevExpress.XtraBars.BarButtonItem btnProgramiKapat;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnHizliErisim;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciEkleSil;
    }
}