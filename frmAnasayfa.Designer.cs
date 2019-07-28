namespace BankaHesaplari
{
    partial class frmAnasayfa
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
            this.mnuAnasayfa = new System.Windows.Forms.MenuStrip();
            this.mitmHesaplar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmHesapHareketleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriler = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmHesapTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmHesapSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmHesapDokumu = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmHesapEkstresi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMüsteriListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnasayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnasayfa
            // 
            this.mnuAnasayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmHesaplar,
            this.mitmHesapHareketleri,
            this.mitmMusteriler,
            this.mitmRaporlar,
            this.mitmCikis});
            this.mnuAnasayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnasayfa.Name = "mnuAnasayfa";
            this.mnuAnasayfa.Size = new System.Drawing.Size(820, 24);
            this.mnuAnasayfa.TabIndex = 1;
            this.mnuAnasayfa.Text = "menuStrip1";
            // 
            // mitmHesaplar
            // 
            this.mitmHesaplar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmHesapTanimlama,
            this.mitmHesapSorgulama});
            this.mitmHesaplar.Name = "mitmHesaplar";
            this.mitmHesaplar.Size = new System.Drawing.Size(65, 20);
            this.mitmHesaplar.Text = "&Hesaplar";
            // 
            // mitmHesapHareketleri
            // 
            this.mitmHesapHareketleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmHesapDokumu});
            this.mitmHesapHareketleri.Name = "mitmHesapHareketleri";
            this.mitmHesapHareketleri.Size = new System.Drawing.Size(112, 20);
            this.mitmHesapHareketleri.Text = "H&esap Hareketleri";
            // 
            // mitmMusteriler
            // 
            this.mitmMusteriler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmMusteriTanimlama,
            this.mitmMusteriSorgulama});
            this.mitmMusteriler.Name = "mitmMusteriler";
            this.mitmMusteriler.Size = new System.Drawing.Size(72, 20);
            this.mitmMusteriler.Text = "&Müşteriler";
            // 
            // mitmRaporlar
            // 
            this.mitmRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmHesapEkstresi,
            this.mitmMüsteriListesi});
            this.mitmRaporlar.Name = "mitmRaporlar";
            this.mitmRaporlar.Size = new System.Drawing.Size(63, 20);
            this.mitmRaporlar.Text = "&Raporlar";
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(44, 20);
            this.mitmCikis.Text = "&Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // mitmHesapTanimlama
            // 
            this.mitmHesapTanimlama.Name = "mitmHesapTanimlama";
            this.mitmHesapTanimlama.Size = new System.Drawing.Size(180, 22);
            this.mitmHesapTanimlama.Text = "Hesap &Tanımlama";
            // 
            // mitmHesapSorgulama
            // 
            this.mitmHesapSorgulama.Name = "mitmHesapSorgulama";
            this.mitmHesapSorgulama.Size = new System.Drawing.Size(180, 22);
            this.mitmHesapSorgulama.Text = "Hesap &Sorgulama";
            // 
            // mitmHesapDokumu
            // 
            this.mitmHesapDokumu.Name = "mitmHesapDokumu";
            this.mitmHesapDokumu.Size = new System.Drawing.Size(180, 22);
            this.mitmHesapDokumu.Text = "Hesap &Dökümü";
            // 
            // mitmMusteriTanimlama
            // 
            this.mitmMusteriTanimlama.Name = "mitmMusteriTanimlama";
            this.mitmMusteriTanimlama.Size = new System.Drawing.Size(180, 22);
            this.mitmMusteriTanimlama.Text = "Müşteri &Tanımlama";
            this.mitmMusteriTanimlama.Click += new System.EventHandler(this.mitmMusteriTanimlama_Click);
            // 
            // mitmMusteriSorgulama
            // 
            this.mitmMusteriSorgulama.Name = "mitmMusteriSorgulama";
            this.mitmMusteriSorgulama.Size = new System.Drawing.Size(180, 22);
            this.mitmMusteriSorgulama.Text = "Müşteri &Sorgulama";
            // 
            // mitmHesapEkstresi
            // 
            this.mitmHesapEkstresi.Name = "mitmHesapEkstresi";
            this.mitmHesapEkstresi.Size = new System.Drawing.Size(180, 22);
            this.mitmHesapEkstresi.Text = "Hesap &Ekstresi";
            // 
            // mitmMüsteriListesi
            // 
            this.mitmMüsteriListesi.Name = "mitmMüsteriListesi";
            this.mitmMüsteriListesi.Size = new System.Drawing.Size(180, 22);
            this.mitmMüsteriListesi.Text = "Müşteri &Listesi";
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 369);
            this.Controls.Add(this.mnuAnasayfa);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnasayfa;
            this.Name = "frmAnasayfa";
            this.Text = "Banka İşlemleri Yönetim Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnasayfa.ResumeLayout(false);
            this.mnuAnasayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnasayfa;
        private System.Windows.Forms.ToolStripMenuItem mitmHesaplar;
        private System.Windows.Forms.ToolStripMenuItem mitmHesapTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmHesapSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmHesapHareketleri;
        private System.Windows.Forms.ToolStripMenuItem mitmHesapDokumu;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriler;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmRaporlar;
        private System.Windows.Forms.ToolStripMenuItem mitmHesapEkstresi;
        private System.Windows.Forms.ToolStripMenuItem mitmMüsteriListesi;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
    }
}