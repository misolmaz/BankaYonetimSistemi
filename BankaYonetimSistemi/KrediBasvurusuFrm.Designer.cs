namespace BankaYonetimSistemi
{
    partial class KrediBasvurusuFrm
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
            this.dgwTaksitler = new System.Windows.Forms.DataGridView();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnBasvur = new System.Windows.Forms.Button();
            this.txtVade = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHesaplar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaksitler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTaksitler
            // 
            this.dgwTaksitler.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgwTaksitler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTaksitler.Location = new System.Drawing.Point(37, 222);
            this.dgwTaksitler.Name = "dgwTaksitler";
            this.dgwTaksitler.RowTemplate.Height = 33;
            this.dgwTaksitler.Size = new System.Drawing.Size(807, 414);
            this.dgwTaksitler.TabIndex = 23;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Lavender;
            this.btnHesapla.Location = new System.Drawing.Point(420, 146);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(188, 44);
            this.btnHesapla.TabIndex = 21;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnBasvur
            // 
            this.btnBasvur.BackColor = System.Drawing.Color.Lavender;
            this.btnBasvur.Location = new System.Drawing.Point(627, 146);
            this.btnBasvur.Name = "btnBasvur";
            this.btnBasvur.Size = new System.Drawing.Size(188, 44);
            this.btnBasvur.TabIndex = 22;
            this.btnBasvur.Text = "Başvur";
            this.btnBasvur.UseVisualStyleBackColor = false;
            this.btnBasvur.Click += new System.EventHandler(this.btnBasvur_Click);
            // 
            // txtVade
            // 
            this.txtVade.Location = new System.Drawing.Point(715, 68);
            this.txtVade.Name = "txtVade";
            this.txtVade.Size = new System.Drawing.Size(100, 31);
            this.txtVade.TabIndex = 20;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(410, 68);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(246, 31);
            this.txtMiktar.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kredi Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Taksit Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kredi Çekilecek Hesap";
            // 
            // cmbHesaplar
            // 
            this.cmbHesaplar.FormattingEnabled = true;
            this.cmbHesaplar.Location = new System.Drawing.Point(37, 68);
            this.cmbHesaplar.Name = "cmbHesaplar";
            this.cmbHesaplar.Size = new System.Drawing.Size(326, 33);
            this.cmbHesaplar.TabIndex = 13;
            // 
            // KrediBasvurusuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(898, 660);
            this.Controls.Add(this.dgwTaksitler);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnBasvur);
            this.Controls.Add(this.txtVade);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHesaplar);
            this.Name = "KrediBasvurusuFrm";
            this.Text = "KrediBasvurusuFrmcs";
            this.Load += new System.EventHandler(this.KrediBasvurusuFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaksitler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTaksitler;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnBasvur;
        private System.Windows.Forms.TextBox txtVade;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHesaplar;
    }
}