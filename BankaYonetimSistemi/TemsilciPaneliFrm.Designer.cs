namespace BankaYonetimSistemi
{
    partial class TemsilciPaneliFrm
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
            this.müşteriİnceleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapAçmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediBaşvurularıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİnceleToolStripMenuItem,
            this.onaylarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1352, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriİnceleToolStripMenuItem
            // 
            this.müşteriİnceleToolStripMenuItem.Name = "müşteriİnceleToolStripMenuItem";
            this.müşteriİnceleToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.müşteriİnceleToolStripMenuItem.Text = "Müşteri İncele";
            this.müşteriİnceleToolStripMenuItem.Click += new System.EventHandler(this.müşteriİnceleToolStripMenuItem_Click);
            // 
            // onaylarToolStripMenuItem
            // 
            this.onaylarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapAçmaToolStripMenuItem,
            this.krediBaşvurularıToolStripMenuItem});
            this.onaylarToolStripMenuItem.Name = "onaylarToolStripMenuItem";
            this.onaylarToolStripMenuItem.Size = new System.Drawing.Size(109, 38);
            this.onaylarToolStripMenuItem.Text = "Onaylar";
            // 
            // hesapAçmaToolStripMenuItem
            // 
            this.hesapAçmaToolStripMenuItem.Name = "hesapAçmaToolStripMenuItem";
            this.hesapAçmaToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.hesapAçmaToolStripMenuItem.Text = "Hesap Açma";
            this.hesapAçmaToolStripMenuItem.Click += new System.EventHandler(this.hesapAçmaToolStripMenuItem_Click);
            // 
            // krediBaşvurularıToolStripMenuItem
            // 
            this.krediBaşvurularıToolStripMenuItem.Name = "krediBaşvurularıToolStripMenuItem";
            this.krediBaşvurularıToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.krediBaşvurularıToolStripMenuItem.Text = "Kredi Başvuruları";
            this.krediBaşvurularıToolStripMenuItem.Click += new System.EventHandler(this.krediBaşvurularıToolStripMenuItem_Click);
            // 
            // TemsilciPaneliFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankaYonetimSistemi.Properties.Resources.bank_icon;
            this.ClientSize = new System.Drawing.Size(1352, 784);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TemsilciPaneliFrm";
            this.Text = "TemsilciPaneliFrm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriİnceleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaylarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapAçmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediBaşvurularıToolStripMenuItem;
    }
}