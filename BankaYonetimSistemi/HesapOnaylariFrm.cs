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
    public partial class HesapOnaylariFrm : Form
    {
        int selectId;
        hesaplar updates;
        public HesapOnaylariFrm()
        {
            InitializeComponent();
        }
        private void hesapListele()
        {
            BYSEntities context = new BYSEntities();
            int temsilciId = Degerler.temsilciId;
           // MessageBox.Show(temsilciId.ToString());
            var hesaplistesi = (from n in context.hesaplar
                                join c in context.temsilciler
                                on n.kID equals c.kID
                                join k in context.kullanicilar
                                on n.kID equals k.kID
                                where (n.onayli == "0") && (c.temsilciID == temsilciId)
                                select new
                                {
                                    KisiId = n.kID,
                                    ad = k.ad,
                                    soyad = k.soyad,
                                    hesapId = n.hesapID,
                                    ParaBirimi = n.dovizID,
                                    Onayli = n.onayli,

                                }).ToList();
            dgwOnayListe.DataSource = hesaplistesi;// context.hesaplar.Where(w => w.onayli == "0").ToList();
                                                   // && context.temsilciler.Where(w => w.temsilciID == Degerler.temsilciId).ToList();
        }
        private void HesapOnaylariFrm_Load(object sender, EventArgs e)
        {
            hesapListele();
            
        }
    

        private void dgwOnayListe_SelectionChanged(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            if (dgwOnayListe.SelectedRows.Count > 0)
            {

                selectId = Convert.ToInt32(dgwOnayListe.SelectedRows[0].Cells[3].Value);
                
                updates = context.hesaplar.Find(selectId);
                txtAd.Text = updates.kullanicilar.ad;
                txtSoyad.Text = updates.kullanicilar.soyad;

                txtDovizTuru.Text = updates.parabirimi.dovizadi;


            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            updates = context.hesaplar.Find(selectId);
            updates.onayli = "1";
           
            context.SaveChanges();
            hesapListele();

        }
    }
}
