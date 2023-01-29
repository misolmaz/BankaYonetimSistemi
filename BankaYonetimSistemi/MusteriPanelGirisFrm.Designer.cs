namespace BankaYonetimSistemi
{
    partial class MusteriPanelGirisFrm
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
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblMusteriler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.BackColor = System.Drawing.SystemColors.Info;
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(43, 115);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(308, 33);
            this.cmbMusteriler.TabIndex = 0;
            this.cmbMusteriler.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriler_SelectedIndexChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGiris.Location = new System.Drawing.Point(427, 109);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(137, 42);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblMusteriler
            // 
            this.lblMusteriler.AutoSize = true;
            this.lblMusteriler.Location = new System.Drawing.Point(38, 58);
            this.lblMusteriler.Name = "lblMusteriler";
            this.lblMusteriler.Size = new System.Drawing.Size(107, 25);
            this.lblMusteriler.TabIndex = 2;
            this.lblMusteriler.Text = "Müsteriler";
            this.lblMusteriler.Click += new System.EventHandler(this.lblMusteriler_Click);
            // 
            // MusteriPanelGirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(618, 294);
            this.Controls.Add(this.lblMusteriler);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.cmbMusteriler);
            this.Name = "MusteriPanelGirisFrm";
            this.Text = "Musteri Paneli Girişi";
            this.Load += new System.EventHandler(this.MusteriPanelGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblMusteriler;
    }
}