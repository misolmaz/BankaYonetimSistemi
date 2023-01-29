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

    public partial class TemsilciPanelGirisFrm : Form
    {
        int temsilciId;
        public TemsilciPanelGirisFrm()
        {
            InitializeComponent();
        }

        private void TemsilciPanelGirisFrm_Load(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();

            List<kullanicilar> ssloc = context.kullanicilar.Where(w => w.rolID == 2).ToList();

            cmbTemsilciler.DataSource = ssloc;
            cmbTemsilciler.ValueMember = "kID";
            cmbTemsilciler.DisplayMember = "ad";
        }

        private void cmbTemsilciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                temsilciId = (int)cmbTemsilciler.SelectedValue;
                Degerler.temsilciId = temsilciId;
            }
            catch { }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            TemsilciPaneliFrm temsilciPaneliFrm = new TemsilciPaneliFrm();
            temsilciPaneliFrm.Name = "temsilciPaneli";
            temsilciPaneliFrm.Text = "Temsilci Paneli";
            if (Application.OpenForms["temsilciPaneli"] == null)
            {

                temsilciPaneliFrm.Show();
            }
        }
    }
}
