namespace BankaYonetimSistemi
{
    partial class MusteriPaneliFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplarımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.paraYatırÇekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraTransferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediİlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKrediBaşvurusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediTaksitiÖdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.krediİlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1727, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.hesaplarımToolStripMenuItem,
            this.toolStripSeparator1,
            this.paraYatırÇekToolStripMenuItem,
            this.paraTransferiToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.işlemlerToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(303, 38);
            this.toolStripMenuItem1.Text = "Hesap Hareketleri";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // hesaplarımToolStripMenuItem
            // 
            this.hesaplarımToolStripMenuItem.Name = "hesaplarımToolStripMenuItem";
            this.hesaplarımToolStripMenuItem.Size = new System.Drawing.Size(303, 38);
            this.hesaplarımToolStripMenuItem.Text = "Yeni Hesap Aç";
            this.hesaplarımToolStripMenuItem.Click += new System.EventHandler(this.hesaplarımToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(300, 6);
            // 
            // paraYatırÇekToolStripMenuItem
            // 
            this.paraYatırÇekToolStripMenuItem.Name = "paraYatırÇekToolStripMenuItem";
            this.paraYatırÇekToolStripMenuItem.Size = new System.Drawing.Size(303, 38);
            this.paraYatırÇekToolStripMenuItem.Text = "Para Yatır / Çek";
            this.paraYatırÇekToolStripMenuItem.Click += new System.EventHandler(this.paraYatırÇekToolStripMenuItem_Click);
            // 
            // paraTransferiToolStripMenuItem
            // 
            this.paraTransferiToolStripMenuItem.Name = "paraTransferiToolStripMenuItem";
            this.paraTransferiToolStripMenuItem.Size = new System.Drawing.Size(303, 38);
            this.paraTransferiToolStripMenuItem.Text = "Para Transferi";
            this.paraTransferiToolStripMenuItem.Click += new System.EventHandler(this.paraTransferiToolStripMenuItem_Click);
            // 
            // krediİlemleriToolStripMenuItem
            // 
            this.krediİlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKrediBaşvurusuToolStripMenuItem,
            this.krediTaksitiÖdeToolStripMenuItem});
            this.krediİlemleriToolStripMenuItem.Name = "krediİlemleriToolStripMenuItem";
            this.krediİlemleriToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.krediİlemleriToolStripMenuItem.Text = "Kredi İşlemleri";
            // 
            // yeniKrediBaşvurusuToolStripMenuItem
            // 
            this.yeniKrediBaşvurusuToolStripMenuItem.Name = "yeniKrediBaşvurusuToolStripMenuItem";
            this.yeniKrediBaşvurusuToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.yeniKrediBaşvurusuToolStripMenuItem.Text = "Yeni Kredi Başvurusu";
            this.yeniKrediBaşvurusuToolStripMenuItem.Click += new System.EventHandler(this.yeniKrediBaşvurusuToolStripMenuItem_Click);
            // 
            // krediTaksitiÖdeToolStripMenuItem
            // 
            this.krediTaksitiÖdeToolStripMenuItem.Name = "krediTaksitiÖdeToolStripMenuItem";
            this.krediTaksitiÖdeToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.krediTaksitiÖdeToolStripMenuItem.Text = "Kredi Taksiti Öde";
            this.krediTaksitiÖdeToolStripMenuItem.Click += new System.EventHandler(this.krediTaksitiÖdeToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgiGüncellemeToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(100, 38);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // bilgiGüncellemeToolStripMenuItem
            // 
            this.bilgiGüncellemeToolStripMenuItem.Name = "bilgiGüncellemeToolStripMenuItem";
            this.bilgiGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.bilgiGüncellemeToolStripMenuItem.Text = "Bilgi Güncelleme";
            this.bilgiGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.bilgiGüncellemeToolStripMenuItem_Click);
            // 
            // MusteriPaneliFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::BankaYonetimSistemi.Properties.Resources.bank_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1727, 1062);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MusteriPaneliFrm";
            this.Text = "MusteriPaneliFrm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hesaplarımToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem paraYatırÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraTransferiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediİlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKrediBaşvurusuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediTaksitiÖdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiGüncellemeToolStripMenuItem;
    }
}