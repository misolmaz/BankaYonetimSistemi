namespace BankaYonetimSistemi
{
    partial class ParaYatirFrm
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
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.btnÇek = new System.Windows.Forms.Button();
            this.btnYatir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.dgwHesapHaraketleri = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHesaplar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHesapHaraketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(99, 178);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(246, 31);
            this.txtAciklama.TabIndex = 30;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(858, 286);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(262, 31);
            this.txtBakiye.TabIndex = 29;
            // 
            // btnÇek
            // 
            this.btnÇek.BackColor = System.Drawing.Color.Bisque;
            this.btnÇek.Location = new System.Drawing.Point(1000, 193);
            this.btnÇek.Name = "btnÇek";
            this.btnÇek.Size = new System.Drawing.Size(120, 50);
            this.btnÇek.TabIndex = 27;
            this.btnÇek.Text = "Çek";
            this.btnÇek.UseVisualStyleBackColor = false;
            this.btnÇek.Click += new System.EventHandler(this.btnÇek_Click);
            // 
            // btnYatir
            // 
            this.btnYatir.BackColor = System.Drawing.Color.Bisque;
            this.btnYatir.Location = new System.Drawing.Point(866, 193);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(120, 50);
            this.btnYatir.TabIndex = 28;
            this.btnYatir.Text = "Yatir";
            this.btnYatir.UseVisualStyleBackColor = false;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Aciklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Miktar";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(99, 273);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(226, 31);
            this.txtMiktar.TabIndex = 24;
            // 
            // dgwHesapHaraketleri
            // 
            this.dgwHesapHaraketleri.BackgroundColor = System.Drawing.Color.Tan;
            this.dgwHesapHaraketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHesapHaraketleri.Location = new System.Drawing.Point(74, 333);
            this.dgwHesapHaraketleri.Name = "dgwHesapHaraketleri";
            this.dgwHesapHaraketleri.RowTemplate.Height = 33;
            this.dgwHesapHaraketleri.Size = new System.Drawing.Size(1046, 456);
            this.dgwHesapHaraketleri.TabIndex = 23;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Bisque;
            this.btnListele.Location = new System.Drawing.Point(726, 193);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(120, 50);
            this.btnListele.TabIndex = 22;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hesap Bakiyesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hesaplar";
            // 
            // cmbHesaplar
            // 
            this.cmbHesaplar.FormattingEnabled = true;
            this.cmbHesaplar.Location = new System.Drawing.Point(99, 77);
            this.cmbHesaplar.Name = "cmbHesaplar";
            this.cmbHesaplar.Size = new System.Drawing.Size(326, 33);
            this.cmbHesaplar.TabIndex = 17;
            // 
            // ParaYatirFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1194, 812);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.btnÇek);
            this.Controls.Add(this.btnYatir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.dgwHesapHaraketleri);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHesaplar);
            this.Name = "ParaYatirFrm";
            this.Text = "ParaYatirFrm";
            this.Load += new System.EventHandler(this.ParaYatirFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHesapHaraketleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Button btnÇek;
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.DataGridView dgwHesapHaraketleri;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHesaplar;
    }
}