namespace BankaYonetimSistemi
{
    partial class KrediOdeFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVadeTarihi = new System.Windows.Forms.TextBox();
            this.txtTaksit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHesaplar = new System.Windows.Forms.ComboBox();
            this.dgwTaksitler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaksitler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Orchid;
            this.btnListele.Location = new System.Drawing.Point(715, 190);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(116, 51);
            this.btnListele.TabIndex = 33;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.Location = new System.Drawing.Point(574, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 51);
            this.button1.TabIndex = 32;
            this.button1.Text = "Öde";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "TaksitTarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Taksit Miktarı";
            // 
            // txtVadeTarihi
            // 
            this.txtVadeTarihi.Location = new System.Drawing.Point(585, 87);
            this.txtVadeTarihi.Name = "txtVadeTarihi";
            this.txtVadeTarihi.Size = new System.Drawing.Size(246, 31);
            this.txtVadeTarihi.TabIndex = 29;
            // 
            // txtTaksit
            // 
            this.txtTaksit.Location = new System.Drawing.Point(259, 87);
            this.txtTaksit.Name = "txtTaksit";
            this.txtTaksit.Size = new System.Drawing.Size(246, 31);
            this.txtTaksit.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kredi Hesabı";
            // 
            // cmbHesaplar
            // 
            this.cmbHesaplar.FormattingEnabled = true;
            this.cmbHesaplar.Location = new System.Drawing.Point(12, 85);
            this.cmbHesaplar.Name = "cmbHesaplar";
            this.cmbHesaplar.Size = new System.Drawing.Size(200, 33);
            this.cmbHesaplar.TabIndex = 24;
            // 
            // dgwTaksitler
            // 
            this.dgwTaksitler.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgwTaksitler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTaksitler.Location = new System.Drawing.Point(19, 286);
            this.dgwTaksitler.Name = "dgwTaksitler";
            this.dgwTaksitler.RowTemplate.Height = 33;
            this.dgwTaksitler.Size = new System.Drawing.Size(829, 341);
            this.dgwTaksitler.TabIndex = 23;
            this.dgwTaksitler.SelectionChanged += new System.EventHandler(this.dgwTaksitler_SelectionChanged);
            // 
            // KrediOdeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(877, 654);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVadeTarihi);
            this.Controls.Add(this.txtTaksit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHesaplar);
            this.Controls.Add(this.dgwTaksitler);
            this.Name = "KrediOdeFrm";
            this.Text = "KrediOdeFrm";
            this.Load += new System.EventHandler(this.KrediOdeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaksitler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVadeTarihi;
        private System.Windows.Forms.TextBox txtTaksit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHesaplar;
        private System.Windows.Forms.DataGridView dgwTaksitler;
    }
}