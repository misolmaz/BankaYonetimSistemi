namespace BankaYonetimSistemi
{
    partial class MudurPaneliFrm
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
            this.tabControlMudur = new System.Windows.Forms.TabControl();
            this.tabKullanicilar = new System.Windows.Forms.TabPage();
            this.btnIncele = new System.Windows.Forms.Button();
            this.lblTemsilci = new System.Windows.Forms.Label();
            this.cmbTemsilci = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tabKasa = new System.Windows.Forms.TabPage();
            this.tabAyarlar = new System.Windows.Forms.TabPage();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.dgwAyarlar = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKurDegeri = new System.Windows.Forms.TextBox();
            this.txtDovizAdi = new System.Windows.Forms.TextBox();
            this.btnKurDuzelt = new System.Windows.Forms.Button();
            this.btnKurSil = new System.Windows.Forms.Button();
            this.btnKurListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgwKurlar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgwKasaHareketleri = new System.Windows.Forms.DataGridView();
            this.tabControlMudur.SuspendLayout();
            this.tabKullanicilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.tabKasa.SuspendLayout();
            this.tabAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKurlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKasaHareketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMudur
            // 
            this.tabControlMudur.Controls.Add(this.tabKullanicilar);
            this.tabControlMudur.Controls.Add(this.tabKasa);
            this.tabControlMudur.Controls.Add(this.tabAyarlar);
            this.tabControlMudur.Location = new System.Drawing.Point(-1, 1);
            this.tabControlMudur.Name = "tabControlMudur";
            this.tabControlMudur.SelectedIndex = 0;
            this.tabControlMudur.Size = new System.Drawing.Size(1171, 816);
            this.tabControlMudur.TabIndex = 0;
            // 
            // tabKullanicilar
            // 
            this.tabKullanicilar.BackColor = System.Drawing.Color.SeaShell;
            this.tabKullanicilar.Controls.Add(this.btnIncele);
            this.tabKullanicilar.Controls.Add(this.lblTemsilci);
            this.tabKullanicilar.Controls.Add(this.cmbTemsilci);
            this.tabKullanicilar.Controls.Add(this.label7);
            this.tabKullanicilar.Controls.Add(this.btnListele);
            this.tabKullanicilar.Controls.Add(this.btnEkle);
            this.tabKullanicilar.Controls.Add(this.dgwListe);
            this.tabKullanicilar.Controls.Add(this.cmbRol);
            this.tabKullanicilar.Controls.Add(this.label6);
            this.tabKullanicilar.Controls.Add(this.label5);
            this.tabKullanicilar.Controls.Add(this.label4);
            this.tabKullanicilar.Controls.Add(this.label3);
            this.tabKullanicilar.Controls.Add(this.label2);
            this.tabKullanicilar.Controls.Add(this.label1);
            this.tabKullanicilar.Controls.Add(this.txtTckn);
            this.tabKullanicilar.Controls.Add(this.txtSoyad);
            this.tabKullanicilar.Controls.Add(this.txtEposta);
            this.tabKullanicilar.Controls.Add(this.txtAdres);
            this.tabKullanicilar.Controls.Add(this.txtTelNo);
            this.tabKullanicilar.Controls.Add(this.txtAd);
            this.tabKullanicilar.Location = new System.Drawing.Point(8, 39);
            this.tabKullanicilar.Name = "tabKullanicilar";
            this.tabKullanicilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabKullanicilar.Size = new System.Drawing.Size(1155, 769);
            this.tabKullanicilar.TabIndex = 0;
            this.tabKullanicilar.Text = "Kullanicilar";
            // 
            // btnIncele
            // 
            this.btnIncele.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnIncele.Location = new System.Drawing.Point(894, 700);
            this.btnIncele.Name = "btnIncele";
            this.btnIncele.Size = new System.Drawing.Size(106, 49);
            this.btnIncele.TabIndex = 10;
            this.btnIncele.Text = "İncele";
            this.btnIncele.UseVisualStyleBackColor = false;
            this.btnIncele.Click += new System.EventHandler(this.btnIncele_Click);
            // 
            // lblTemsilci
            // 
            this.lblTemsilci.AutoSize = true;
            this.lblTemsilci.Location = new System.Drawing.Point(714, 294);
            this.lblTemsilci.Name = "lblTemsilci";
            this.lblTemsilci.Size = new System.Drawing.Size(184, 25);
            this.lblTemsilci.TabIndex = 30;
            this.lblTemsilci.Text = "Müşteri Temsilcisi";
            // 
            // cmbTemsilci
            // 
            this.cmbTemsilci.FormattingEnabled = true;
            this.cmbTemsilci.Location = new System.Drawing.Point(708, 337);
            this.cmbTemsilci.Name = "cmbTemsilci";
            this.cmbTemsilci.Size = new System.Drawing.Size(256, 33);
            this.cmbTemsilci.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Adres";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnListele.Location = new System.Drawing.Point(1014, 700);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(92, 49);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEkle.Location = new System.Drawing.Point(1014, 328);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 49);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgwListe
            // 
            this.dgwListe.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Location = new System.Drawing.Point(28, 394);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.RowTemplate.Height = 33;
            this.dgwListe.Size = new System.Drawing.Size(1105, 300);
            this.dgwListe.TabIndex = 11;
            this.dgwListe.TabStop = false;
            this.dgwListe.SelectionChanged += new System.EventHandler(this.dgwListe_SelectionChanged);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(395, 241);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(256, 33);
            this.cmbRol.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Kullanıcı Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "e Posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tel No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tckn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(65, 241);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(270, 31);
            this.txtTckn.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(389, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(270, 31);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(389, 152);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(270, 31);
            this.txtEposta.TabIndex = 3;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(708, 65);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(332, 203);
            this.txtAdres.TabIndex = 6;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(65, 152);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(270, 31);
            this.txtTelNo.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(65, 65);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(270, 31);
            this.txtAd.TabIndex = 0;
            // 
            // tabKasa
            // 
            this.tabKasa.BackColor = System.Drawing.Color.Bisque;
            this.tabKasa.Controls.Add(this.button1);
            this.tabKasa.Controls.Add(this.txtBakiye);
            this.tabKasa.Controls.Add(this.label10);
            this.tabKasa.Controls.Add(this.dgwKasaHareketleri);
            this.tabKasa.Location = new System.Drawing.Point(8, 39);
            this.tabKasa.Name = "tabKasa";
            this.tabKasa.Padding = new System.Windows.Forms.Padding(3);
            this.tabKasa.Size = new System.Drawing.Size(1155, 769);
            this.tabKasa.TabIndex = 1;
            this.tabKasa.Text = "Kasa Hareketleri";
            this.tabKasa.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // tabAyarlar
            // 
            this.tabAyarlar.BackColor = System.Drawing.Color.MistyRose;
            this.tabAyarlar.Controls.Add(this.txtDeger);
            this.tabAyarlar.Controls.Add(this.btnDegistir);
            this.tabAyarlar.Controls.Add(this.lblAd);
            this.tabAyarlar.Controls.Add(this.dgwAyarlar);
            this.tabAyarlar.Controls.Add(this.label8);
            this.tabAyarlar.Controls.Add(this.label9);
            this.tabAyarlar.Controls.Add(this.txtKurDegeri);
            this.tabAyarlar.Controls.Add(this.txtDovizAdi);
            this.tabAyarlar.Controls.Add(this.btnKurDuzelt);
            this.tabAyarlar.Controls.Add(this.btnKurSil);
            this.tabAyarlar.Controls.Add(this.btnKurListele);
            this.tabAyarlar.Controls.Add(this.btnKaydet);
            this.tabAyarlar.Controls.Add(this.dgwKurlar);
            this.tabAyarlar.Location = new System.Drawing.Point(8, 39);
            this.tabAyarlar.Name = "tabAyarlar";
            this.tabAyarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAyarlar.Size = new System.Drawing.Size(1155, 769);
            this.tabAyarlar.TabIndex = 2;
            this.tabAyarlar.Text = "Ayarlar";
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(747, 65);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(147, 31);
            this.txtDeger.TabIndex = 16;
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.Turquoise;
            this.btnDegistir.Location = new System.Drawing.Point(981, 62);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(122, 37);
            this.btnDegistir.TabIndex = 15;
            this.btnDegistir.Text = "Güncelle";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(635, 71);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(70, 25);
            this.lblAd.TabIndex = 14;
            this.lblAd.Text = "label1";
            // 
            // dgwAyarlar
            // 
            this.dgwAyarlar.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgwAyarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAyarlar.Location = new System.Drawing.Point(624, 149);
            this.dgwAyarlar.Name = "dgwAyarlar";
            this.dgwAyarlar.RowTemplate.Height = 33;
            this.dgwAyarlar.Size = new System.Drawing.Size(505, 238);
            this.dgwAyarlar.TabIndex = 13;
            this.dgwAyarlar.SelectionChanged += new System.EventHandler(this.dgwAyarlar_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kur Değeri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Döviz Adı";
            // 
            // txtKurDegeri
            // 
            this.txtKurDegeri.Location = new System.Drawing.Point(234, 70);
            this.txtKurDegeri.Name = "txtKurDegeri";
            this.txtKurDegeri.Size = new System.Drawing.Size(236, 31);
            this.txtKurDegeri.TabIndex = 9;
            // 
            // txtDovizAdi
            // 
            this.txtDovizAdi.Location = new System.Drawing.Point(23, 70);
            this.txtDovizAdi.Name = "txtDovizAdi";
            this.txtDovizAdi.Size = new System.Drawing.Size(190, 31);
            this.txtDovizAdi.TabIndex = 10;
            // 
            // btnKurDuzelt
            // 
            this.btnKurDuzelt.BackColor = System.Drawing.Color.Turquoise;
            this.btnKurDuzelt.Location = new System.Drawing.Point(344, 404);
            this.btnKurDuzelt.Name = "btnKurDuzelt";
            this.btnKurDuzelt.Size = new System.Drawing.Size(101, 47);
            this.btnKurDuzelt.TabIndex = 5;
            this.btnKurDuzelt.Text = "Değiştir";
            this.btnKurDuzelt.UseVisualStyleBackColor = false;
            this.btnKurDuzelt.Click += new System.EventHandler(this.btnKurDuzelt_Click);
            // 
            // btnKurSil
            // 
            this.btnKurSil.BackColor = System.Drawing.Color.Turquoise;
            this.btnKurSil.Location = new System.Drawing.Point(224, 404);
            this.btnKurSil.Name = "btnKurSil";
            this.btnKurSil.Size = new System.Drawing.Size(101, 47);
            this.btnKurSil.TabIndex = 6;
            this.btnKurSil.Text = "Sil";
            this.btnKurSil.UseVisualStyleBackColor = false;
            this.btnKurSil.Click += new System.EventHandler(this.btnKurSil_Click);
            // 
            // btnKurListele
            // 
            this.btnKurListele.BackColor = System.Drawing.Color.Turquoise;
            this.btnKurListele.Location = new System.Drawing.Point(465, 404);
            this.btnKurListele.Name = "btnKurListele";
            this.btnKurListele.Size = new System.Drawing.Size(101, 47);
            this.btnKurListele.TabIndex = 7;
            this.btnKurListele.Text = "Listele";
            this.btnKurListele.UseVisualStyleBackColor = false;
            this.btnKurListele.Click += new System.EventHandler(this.btnKurListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Turquoise;
            this.btnKaydet.Location = new System.Drawing.Point(486, 62);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 47);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgwKurlar
            // 
            this.dgwKurlar.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgwKurlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKurlar.Location = new System.Drawing.Point(23, 149);
            this.dgwKurlar.Name = "dgwKurlar";
            this.dgwKurlar.RowTemplate.Height = 33;
            this.dgwKurlar.Size = new System.Drawing.Size(543, 238);
            this.dgwKurlar.TabIndex = 4;
            this.dgwKurlar.SelectionChanged += new System.EventHandler(this.dgwKurlar_SelectionChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(881, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 66);
            this.button1.TabIndex = 25;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(827, 106);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(262, 31);
            this.txtBakiye.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Hesap Bakiyesi";
            // 
            // dgwKasaHareketleri
            // 
            this.dgwKasaHareketleri.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgwKasaHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKasaHareketleri.Location = new System.Drawing.Point(43, 165);
            this.dgwKasaHareketleri.Name = "dgwKasaHareketleri";
            this.dgwKasaHareketleri.RowTemplate.Height = 33;
            this.dgwKasaHareketleri.Size = new System.Drawing.Size(1046, 479);
            this.dgwKasaHareketleri.TabIndex = 22;
            // 
            // MudurPaneliFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1226, 829);
            this.Controls.Add(this.tabControlMudur);
            this.Name = "MudurPaneliFrm";
            this.Text = "MudurPaneliFrm";
            this.Load += new System.EventHandler(this.MudurPaneliFrm_Load);
            this.Resize += new System.EventHandler(this.MudurPaneliFrm_Resize);
            this.tabControlMudur.ResumeLayout(false);
            this.tabKullanicilar.ResumeLayout(false);
            this.tabKullanicilar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.tabKasa.ResumeLayout(false);
            this.tabKasa.PerformLayout();
            this.tabAyarlar.ResumeLayout(false);
            this.tabAyarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKurlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKasaHareketleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMudur;
        private System.Windows.Forms.TabPage tabKullanicilar;
        private System.Windows.Forms.TabPage tabKasa;
        private System.Windows.Forms.TabPage tabAyarlar;
        private System.Windows.Forms.Button btnIncele;
        private System.Windows.Forms.Label lblTemsilci;
        private System.Windows.Forms.ComboBox cmbTemsilci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKurDegeri;
        private System.Windows.Forms.TextBox txtDovizAdi;
        private System.Windows.Forms.Button btnKurDuzelt;
        private System.Windows.Forms.Button btnKurSil;
        private System.Windows.Forms.Button btnKurListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgwKurlar;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DataGridView dgwAyarlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgwKasaHareketleri;
    }
}