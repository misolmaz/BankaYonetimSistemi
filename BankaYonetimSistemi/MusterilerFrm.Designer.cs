namespace BankaYonetimSistemi
{
    partial class MusterilerFrm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dgwMusterListesi = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHareket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusterListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.LawnGreen;
            this.btnListele.Location = new System.Drawing.Point(975, 749);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(116, 45);
            this.btnListele.TabIndex = 56;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "e Posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tel No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tc No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Ad";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(39, 178);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(270, 31);
            this.txtTckn.TabIndex = 51;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(363, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(270, 31);
            this.txtSoyad.TabIndex = 45;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(39, 284);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(270, 31);
            this.txtEposta.TabIndex = 53;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(675, 85);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(410, 183);
            this.txtAdres.TabIndex = 55;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(369, 172);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(270, 31);
            this.txtTelNo.TabIndex = 52;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(39, 80);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(270, 31);
            this.txtAd.TabIndex = 44;
            // 
            // dgwMusterListesi
            // 
            this.dgwMusterListesi.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgwMusterListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusterListesi.Location = new System.Drawing.Point(45, 355);
            this.dgwMusterListesi.Name = "dgwMusterListesi";
            this.dgwMusterListesi.RowTemplate.Height = 33;
            this.dgwMusterListesi.Size = new System.Drawing.Size(1046, 370);
            this.dgwMusterListesi.TabIndex = 40;
            this.dgwMusterListesi.SelectionChanged += new System.EventHandler(this.dgwMusterListesi_SelectionChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnUpdate.Location = new System.Drawing.Point(842, 749);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 45);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHareket
            // 
            this.btnHareket.BackColor = System.Drawing.Color.LawnGreen;
            this.btnHareket.Location = new System.Drawing.Point(710, 749);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(116, 45);
            this.btnHareket.TabIndex = 56;
            this.btnHareket.Text = "Gözlem";
            this.btnHareket.UseVisualStyleBackColor = false;
            this.btnHareket.Click += new System.EventHandler(this.btnHareket_Click);
            // 
            // MusterilerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1148, 817);
            this.Controls.Add(this.btnHareket);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dgwMusterListesi);
            this.Name = "MusterilerFrm";
            this.Text = "MusterilerFrm";
            this.Load += new System.EventHandler(this.MusterilerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusterListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DataGridView dgwMusterListesi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHareket;
    }
}