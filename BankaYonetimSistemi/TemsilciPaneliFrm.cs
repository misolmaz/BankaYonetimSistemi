using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaYonetimSistemi
{
    public partial class TemsilciPaneliFrm : Form
    {
        public TemsilciPaneliFrm()
        {
            InitializeComponent();
        }

        private void müşteriİnceleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusterilerFrm musterilerFrm = new MusterilerFrm();
            musterilerFrm.Name = "musteriler";
            musterilerFrm.Text = "Müşteri Gözlem";
            if (Application.OpenForms["musteriler"] == null)
            {

                musterilerFrm.Show();
                musterilerFrm.MdiParent = this;
            }
        }

        private void hesapAçmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapOnaylariFrm hesapOnaylariFrm = new HesapOnaylariFrm();
            hesapOnaylariFrm.Name = "hesapOnaylari";
            hesapOnaylariFrm.Text = "Hesap Onayları";
            if (Application.OpenForms["hesapOnaylari"] == null)
            {

                hesapOnaylariFrm.Show();
                hesapOnaylariFrm.MdiParent = this;
            }
        }

        private void krediBaşvurularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediOnayFrm krediOnayFrm = new KrediOnayFrm();
            krediOnayFrm.Name = "krediOnay";
            krediOnayFrm.Text = "Kredi Onayları";
            if (Application.OpenForms["krediOnay"] == null)
            {

                krediOnayFrm.Show();
                krediOnayFrm.MdiParent = this;
            }
        }
    }
}
