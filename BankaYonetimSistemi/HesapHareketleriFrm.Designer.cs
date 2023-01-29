namespace BankaYonetimSistemi
{
    partial class HesapHareketleriFrm
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
            this.btnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHesaplar = new System.Windows.Forms.ComboBox();
            this.dgwHesapHaraketleri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHesapHaraketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Orange;
            this.btnListele.Location = new System.Drawing.Point(826, 99);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(173, 51);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hesaplarım";
            // 
            // cmbHesaplar
            // 
            this.cmbHesaplar.FormattingEnabled = true;
            this.cmbHesaplar.Location = new System.Drawing.Point(49, 109);
            this.cmbHesaplar.Name = "cmbHesaplar";
            this.cmbHesaplar.Size = new System.Drawing.Size(326, 33);
            this.cmbHesaplar.TabIndex = 7;
            // 
            // dgwHesapHaraketleri
            // 
            this.dgwHesapHaraketleri.BackgroundColor = System.Drawing.Color.Linen;
            this.dgwHesapHaraketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHesapHaraketleri.Location = new System.Drawing.Point(49, 190);
            this.dgwHesapHaraketleri.Name = "dgwHesapHaraketleri";
            this.dgwHesapHaraketleri.RowTemplate.Height = 33;
            this.dgwHesapHaraketleri.Size = new System.Drawing.Size(960, 402);
            this.dgwHesapHaraketleri.TabIndex = 6;
            // 
            // HesapHareketleriFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1060, 652);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHesaplar);
            this.Controls.Add(this.dgwHesapHaraketleri);
            this.Name = "HesapHareketleriFrm";
            this.Text = "HesapHareketleriFrm";
            this.Load += new System.EventHandler(this.HesapHareketleriFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHesapHaraketleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHesaplar;
        private System.Windows.Forms.DataGridView dgwHesapHaraketleri;
    }
}