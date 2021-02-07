namespace OtoparkOtomasyonu
{
    partial class frmOtoparkGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtoparkGiris));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnİptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.cmbParkYeri = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtGirisTarihi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParkYeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGirisTarihi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnİptal);
            this.panelControl1.Controls.Add(this.btnKaydet);
            this.panelControl1.Controls.Add(this.txtPlaka);
            this.panelControl1.Controls.Add(this.cmbParkYeri);
            this.panelControl1.Controls.Add(this.mskTelefon);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtAdSoyad);
            this.panelControl1.Controls.Add(this.txtGirisTarihi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 421);
            this.panelControl1.TabIndex = 0;
            // 
            // btnİptal
            // 
            this.btnİptal.Appearance.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİptal.Appearance.Options.UseFont = true;
            this.btnİptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.ImageOptions.Image")));
            this.btnİptal.Location = new System.Drawing.Point(555, 272);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(156, 40);
            this.btnİptal.TabIndex = 45;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(241, 272);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(156, 40);
            this.btnKaydet.TabIndex = 44;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.EditValue = "";
            this.txtPlaka.Location = new System.Drawing.Point(241, 183);
            this.txtPlaka.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txtPlaka.Properties.Appearance.Options.UseFont = true;
            this.txtPlaka.Properties.Appearance.Options.UseForeColor = true;
            this.txtPlaka.Size = new System.Drawing.Size(156, 26);
            this.txtPlaka.TabIndex = 43;
            // 
            // cmbParkYeri
            // 
            this.cmbParkYeri.Location = new System.Drawing.Point(555, 146);
            this.cmbParkYeri.Margin = new System.Windows.Forms.Padding(2);
            this.cmbParkYeri.Name = "cmbParkYeri";
            this.cmbParkYeri.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbParkYeri.Properties.Appearance.Options.UseFont = true;
            this.cmbParkYeri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbParkYeri.Size = new System.Drawing.Size(156, 26);
            this.cmbParkYeri.TabIndex = 42;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.ForeColor = System.Drawing.Color.Gray;
            this.mskTelefon.Location = new System.Drawing.Point(241, 146);
            this.mskTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(156, 25);
            this.mskTelefon.TabIndex = 41;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(483, 108);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 20);
            this.labelControl5.TabIndex = 40;
            this.labelControl5.Text = "Giriş Tarihi:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(490, 147);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 20);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Park Yeri:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(198, 182);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 20);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Plaka:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(187, 145);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 20);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Telefon:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(171, 108);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 20);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Ad-Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.EditValue = "";
            this.txtAdSoyad.Location = new System.Drawing.Point(241, 108);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txtAdSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtAdSoyad.Properties.Appearance.Options.UseForeColor = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(156, 26);
            this.txtAdSoyad.TabIndex = 34;
            // 
            // txtGirisTarihi
            // 
            this.txtGirisTarihi.EditValue = "";
            this.txtGirisTarihi.Enabled = false;
            this.txtGirisTarihi.Location = new System.Drawing.Point(555, 108);
            this.txtGirisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.txtGirisTarihi.Name = "txtGirisTarihi";
            this.txtGirisTarihi.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisTarihi.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txtGirisTarihi.Properties.Appearance.Options.UseFont = true;
            this.txtGirisTarihi.Properties.Appearance.Options.UseForeColor = true;
            this.txtGirisTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtGirisTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtGirisTarihi.Size = new System.Drawing.Size(156, 26);
            this.txtGirisTarihi.TabIndex = 35;
            // 
            // frmOtoparkGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 421);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOtoparkGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ARAÇ GİRİŞ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmOtoparkGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParkYeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGirisTarihi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnİptal;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private DevExpress.XtraEditors.ComboBoxEdit cmbParkYeri;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.TextEdit txtGirisTarihi;
    }
}