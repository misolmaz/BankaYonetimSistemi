namespace BankaYonetimSistemi
{
    partial class HesapAcFrm
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
            this.btnBasvur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDoviz = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBasvur
            // 
            this.btnBasvur.BackColor = System.Drawing.Color.MistyRose;
            this.btnBasvur.Location = new System.Drawing.Point(298, 104);
            this.btnBasvur.Name = "btnBasvur";
            this.btnBasvur.Size = new System.Drawing.Size(141, 53);
            this.btnBasvur.TabIndex = 6;
            this.btnBasvur.Text = "Başvur";
            this.btnBasvur.UseVisualStyleBackColor = false;
            this.btnBasvur.Click += new System.EventHandler(this.btnBasvur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Döviz Türü";
            // 
            // cmbDoviz
            // 
            this.cmbDoviz.FormattingEnabled = true;
            this.cmbDoviz.Location = new System.Drawing.Point(24, 115);
            this.cmbDoviz.Name = "cmbDoviz";
            this.cmbDoviz.Size = new System.Drawing.Size(179, 33);
            this.cmbDoviz.TabIndex = 4;
            // 
            // HesapAcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(473, 267);
            this.Controls.Add(this.btnBasvur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDoviz);
            this.Name = "HesapAcFrm";
            this.Text = "HesapAcFrm";
            this.Load += new System.EventHandler(this.HesapAcFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasvur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDoviz;
    }
}