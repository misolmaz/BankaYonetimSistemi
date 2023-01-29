namespace BankaYonetimSistemi
{
    partial class AnaGirisFrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMusteri = new System.Windows.Forms.Button();
            this.BtnTemsilci = new System.Windows.Forms.Button();
            this.BtnMudur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.Bisque;
            this.btnMusteri.Location = new System.Drawing.Point(60, 141);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(210, 90);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "Müşteri Paneli";
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // BtnTemsilci
            // 
            this.BtnTemsilci.BackColor = System.Drawing.Color.Bisque;
            this.BtnTemsilci.Location = new System.Drawing.Point(307, 141);
            this.BtnTemsilci.Name = "BtnTemsilci";
            this.BtnTemsilci.Size = new System.Drawing.Size(210, 90);
            this.BtnTemsilci.TabIndex = 0;
            this.BtnTemsilci.Text = "Temsilci Paneli";
            this.BtnTemsilci.UseVisualStyleBackColor = false;
            this.BtnTemsilci.Click += new System.EventHandler(this.BtnTemsilci_Click);
            // 
            // BtnMudur
            // 
            this.BtnMudur.BackColor = System.Drawing.Color.Bisque;
            this.BtnMudur.Location = new System.Drawing.Point(564, 141);
            this.BtnMudur.Name = "BtnMudur";
            this.BtnMudur.Size = new System.Drawing.Size(210, 90);
            this.BtnMudur.TabIndex = 0;
            this.BtnMudur.Text = "Müdür Paneli";
            this.BtnMudur.UseVisualStyleBackColor = false;
            this.BtnMudur.Click += new System.EventHandler(this.BtnMudur_Click);
            // 
            // AnaGirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(897, 406);
            this.Controls.Add(this.BtnMudur);
            this.Controls.Add(this.BtnTemsilci);
            this.Controls.Add(this.btnMusteri);
            this.Name = "AnaGirisFrm";
            this.Text = "Banka Yönetim Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button BtnTemsilci;
        private System.Windows.Forms.Button BtnMudur;
    }
}

