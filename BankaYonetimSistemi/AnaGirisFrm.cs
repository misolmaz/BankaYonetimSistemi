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
    public partial class AnaGirisFrm : Form
    {
        public AnaGirisFrm()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriPanelGirisFrm musteriPanelGirisFrm = new MusteriPanelGirisFrm();
            musteriPanelGirisFrm.Name = "MusteriPAnelGiris";
            if (Application.OpenForms["MusteriPAnelGiris"] == null)
            {

                musteriPanelGirisFrm.Show();
            }
        }

        private void BtnMudur_Click(object sender, EventArgs e)
        {
            MudurPaneliFrm mudurPaneliFrm = new MudurPaneliFrm();
            mudurPaneliFrm.Name = "mudurPaneli";
            mudurPaneliFrm.Text = "Banka Müdürü";
            if (Application.OpenForms["mudurPaneli"] == null)
            {

                mudurPaneliFrm.Show();
            }
        }

        private void BtnTemsilci_Click(object sender, EventArgs e)
        {
            TemsilciPanelGirisFrm temsilciPanelGirisFrm = new TemsilciPanelGirisFrm();
            temsilciPanelGirisFrm.Name = "temsilciPanelGiris";
            temsilciPanelGirisFrm.Text = "Temsilci Panel Girişi";
            if (Application.OpenForms["temsilciPanelGiris"] == null)
            {

                temsilciPanelGirisFrm.Show();
            }
        }
    }
}
