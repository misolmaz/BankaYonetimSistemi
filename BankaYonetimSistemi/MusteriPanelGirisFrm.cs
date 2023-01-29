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
    
    public partial class MusteriPanelGirisFrm : Form
    {
        int musteriId;
        public MusteriPanelGirisFrm()
        {
            InitializeComponent();
        }

        private void MusteriPanelGiris_Load(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();

            List<kullanicilar> ssloc = context.kullanicilar.Where(w=>w.rolID==1).ToList();
           
            cmbMusteriler.DataSource = ssloc;
            cmbMusteriler.ValueMember = "kID";
            cmbMusteriler.DisplayMember = "ad";
        }

        private void cmbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                musteriId = (int)cmbMusteriler.SelectedValue;
                Degerler.musteriId = musteriId;
            } catch { }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            MusteriPaneliFrm musteriPaneliFrm = new MusteriPaneliFrm();
            musteriPaneliFrm.Name = "musteriPaneli";
            musteriPaneliFrm.Text = "Müşteri Paneli";
            if (Application.OpenForms["musteriPaneli"] == null)
            {

                musteriPaneliFrm.Show();
            }
        }

        private void lblMusteriler_Click(object sender, EventArgs e)
        {

        }
    }
}
