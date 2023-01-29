namespace BankaYonetimSistemi
{
    partial class HavaleFrm
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
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHedefMusteri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbHedefHesap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHesaplar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Wheat;
            this.btnGonder.Location = new System.Drawing.Point(842, 385);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(147, 66);
            this.btnGonder.TabIndex = 34;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(673, 280);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 31);
            this.txtAciklama.TabIndex = 32;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(392, 280);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(202, 31);
            this.txtMiktar.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Havale Yapılacak Kişi";
            // 
            // cmbHedefMusteri
            // 
            this.cmbHedefMusteri.FormattingEnabled = true;
            this.cmbHedefMusteri.Location = new System.Drawing.Point(380, 130);
            this.cmbHedefMusteri.Name = "cmbHedefMusteri";
            this.cmbHedefMusteri.Size = new System.Drawing.Size(246, 33);
            this.cmbHedefMusteri.TabIndex = 29;
            this.cmbHedefMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbHedefMusteri_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Aciklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hedef Hesap";
            // 
            // CmbHedefHesap
            // 
            this.CmbHedefHesap.FormattingEnabled = true;
            this.CmbHedefHesap.Location = new System.Drawing.Point(663, 130);
            this.CmbHedefHesap.Name = "CmbHedefHesap";
            this.CmbHedefHesap.Size = new System.Drawing.Size(326, 33);
            this.CmbHedefHesap.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Para Çekilecek Hesap";
            // 
            // cmbHesaplar
            // 
            this.cmbHesaplar.FormattingEnabled = true;
            this.cmbHesaplar.Location = new System.Drawing.Point(380, 54);
            this.cmbHesaplar.Name = "cmbHesaplar";
            this.cmbHesaplar.Size = new System.Drawing.Size(179, 33);
            this.cmbHesaplar.TabIndex = 20;
            // 
            // HavaleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1030, 488);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbHedefMusteri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbHedefHesap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHesaplar);
            this.Name = "HavaleFrm";
            this.Text = "HavaleFrm";
            this.Load += new System.EventHandler(this.HavaleFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHedefMusteri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbHedefHesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHesaplar;
    }
}