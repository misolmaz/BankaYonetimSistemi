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
    public partial class HesapHareketleriFrm : Form
    {
        public HesapHareketleriFrm()
        {
            InitializeComponent();
        }

        private void HesapHareketleriFrm_Load(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            int musteriId = Degerler.musteriId;
            var hesaplistesi = (from n in context.hesaplar
                                join p in context.parabirimi
                                on n.dovizID equals p.dovizID
                                
                                where (n.onayli == "1") && (n.kID==musteriId)
                                select new
                                {
                                   
                                    hesapId = n.hesapID,
                                    ParaBirimi = p.dovizadi,
                                 

                                }).ToList();
            cmbHesaplar.DataSource = hesaplistesi;
            cmbHesaplar.DisplayMember="ParaBirimi";
            cmbHesaplar.ValueMember = "hesapId";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            int hesapId = (int) cmbHesaplar.SelectedValue;
            dgwHesapHaraketleri.DataSource = context.hesapharaketleri.Where(w => w.hesapId == hesapId).ToList();


        }
    }
}
