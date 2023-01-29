namespace BankaYonetimSistemi
{
    partial class TemsilciPanelGirisFrm
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
            this.lblMusteriler = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.cmbTemsilciler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMusteriler
            // 
            this.lblMusteriler.AutoSize = true;
            this.lblMusteriler.Location = new System.Drawing.Point(28, 47);
            this.lblMusteriler.Name = "lblMusteriler";
            this.lblMusteriler.Size = new System.Drawing.Size(197, 25);
            this.lblMusteriler.TabIndex = 5;
            this.lblMusteriler.Text = "Müşteri Temsilcileri";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGiris.Location = new System.Drawing.Point(417, 98);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(137, 42);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // cmbTemsilciler
            // 
            this.cmbTemsilciler.BackColor = System.Drawing.SystemColors.Info;
            this.cmbTemsilciler.FormattingEnabled = true;
            this.cmbTemsilciler.Location = new System.Drawing.Point(33, 104);
            this.cmbTemsilciler.Name = "cmbTemsilciler";
            this.cmbTemsilciler.Size = new System.Drawing.Size(308, 33);
            this.cmbTemsilciler.TabIndex = 3;
            this.cmbTemsilciler.SelectedIndexChanged += new System.EventHandler(this.cmbTemsilciler_SelectedIndexChanged);
            // 
            // TemsilciPanelGirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(575, 229);
            this.Controls.Add(this.lblMusteriler);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.cmbTemsilciler);
            this.Name = "TemsilciPanelGirisFrm";
            this.Text = "TemsilciPanelGirisFrm";
            this.Load += new System.EventHandler(this.TemsilciPanelGirisFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriler;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.ComboBox cmbTemsilciler;
    }
}