namespace BankaYonetimSistemi
{
    partial class KrediOnayFrm
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
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVade = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dgwBasvuruListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBasvuruListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnOnayla.Location = new System.Drawing.Point(851, 92);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(133, 42);
            this.btnOnayla.TabIndex = 17;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Taksit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ad";
            // 
            // txtVade
            // 
            this.txtVade.Location = new System.Drawing.Point(571, 98);
            this.txtVade.Name = "txtVade";
            this.txtVade.Size = new System.Drawing.Size(100, 31);
            this.txtVade.TabIndex = 12;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(395, 98);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(123, 31);
            this.txtMiktar.TabIndex = 11;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(212, 98);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(139, 31);
            this.txtSoyad.TabIndex = 10;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(24, 98);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(147, 31);
            this.txtAd.TabIndex = 9;
            // 
            // dgwBasvuruListesi
            // 
            this.dgwBasvuruListesi.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgwBasvuruListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBasvuruListesi.Location = new System.Drawing.Point(22, 186);
            this.dgwBasvuruListesi.Name = "dgwBasvuruListesi";
            this.dgwBasvuruListesi.RowTemplate.Height = 33;
            this.dgwBasvuruListesi.Size = new System.Drawing.Size(962, 345);
            this.dgwBasvuruListesi.TabIndex = 8;
            this.dgwBasvuruListesi.SelectionChanged += new System.EventHandler(this.dgwBasvuruListesi_SelectionChanged);
            // 
            // KrediOnayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1001, 558);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVade);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dgwBasvuruListesi);
            this.Name = "KrediOnayFrm";
            this.Text = "KrediOnayFrm";
            this.Load += new System.EventHandler(this.KrediOnayFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBasvuruListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVade;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DataGridView dgwBasvuruListesi;
    }
}