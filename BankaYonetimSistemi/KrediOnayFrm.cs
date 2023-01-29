using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaYonetimSistemi
{
    public partial class KrediOnayFrm : Form
    {
        int selId;
        int hesapId;
        krediler updates;
        public KrediOnayFrm()
        {
            InitializeComponent();
        }

        private void KrediOnayFrm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            BYSEntities context = new BYSEntities();
            int temsilciId = Degerler.temsilciId;
            var krediOnayListesi = (from h in context.hesaplar
                                    join k in context.kullanicilar
                                    on h.kID equals k.kID
                                    join kr in context.krediler
                                    on h.hesapID equals kr.hesapID
                                    where (kr.onay == 0)
                                    select new
                                    {
                                        krediId = kr.krediID,
                                        ad = k.ad,
                                        soyad = k.soyad,
                                        hesapId = h.hesapID,
                                        miktar = kr.miktar,
                                        taksit= kr.vade

                                    }).ToList();
            dgwBasvuruListesi.DataSource = krediOnayListesi;
        }

        private void dgwBasvuruListesi_SelectionChanged(object sender, EventArgs e)
        {

            selId = (int) dgwBasvuruListesi.CurrentRow.Cells["krediID"].Value;
            txtAd.Text = dgwBasvuruListesi.CurrentRow.Cells["ad"].Value.ToString();
            txtSoyad.Text = dgwBasvuruListesi.CurrentRow.Cells["soyad"].Value.ToString();
            txtMiktar.Text = dgwBasvuruListesi.CurrentRow.Cells["miktar"].Value.ToString();
            txtVade.Text = dgwBasvuruListesi.CurrentRow.Cells["taksit"].Value.ToString();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            updates = context.krediler.Find(selId);

            updates.onay = 1;
            hesapId = updates.hesapID;

            context.SaveChanges();

            krediKullandir();
            kasaKaydi();
            MessageBox.Show("Kredi Kullandırma Başarılı");
            listele();

        }

        private void kasaKaydi()
        {
            BYSEntities context = new BYSEntities();
            kasaharaketleri krediOdeme = new kasaharaketleri();

            krediOdeme.krediID = selId;
            krediOdeme.hesapID = hesapId;
            krediOdeme.miktar = Convert.ToInt32(txtMiktar.Text);
            krediOdeme.tarih = DateTime.Now.ToShortDateString();
            krediOdeme.aciklama = "Kredi kullanımı";
            krediOdeme.islemturu = 2;


            try
            {
                context.kasaharaketleri.Add(krediOdeme);
                context.SaveChanges();


            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    string message = "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:" +
                        eve.Entry.Entity.GetType().Name + eve.Entry.State;
                    MessageBox.Show(message);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        String message2 = "- Property: \"{0}\", Error: \"{1}\"" +
                            ve.PropertyName + ve.ErrorMessage;
                        MessageBox.Show(message2);
                    }
                }
                throw;
            }
        }

        private void krediKullandir()
        {

            BYSEntities context = new BYSEntities();
            hesapharaketleri hesapHareketi = new hesapharaketleri();

            hesapHareketi.hesapId = hesapId;
            hesapHareketi.hedefHesapID = 0;
            hesapHareketi.miktar = Convert.ToInt32(txtMiktar.Text);
            hesapHareketi.tarih = DateTime.Now.ToShortDateString();
            hesapHareketi.aciklama = "Kredi kullanımı";
            hesapHareketi.islemturu = 1;


            try
            {
                context.hesapharaketleri.Add(hesapHareketi);
                context.SaveChanges();


            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    string message = "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:" +
                        eve.Entry.Entity.GetType().Name + eve.Entry.State;
                    MessageBox.Show(message);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        String message2 = "- Property: \"{0}\", Error: \"{1}\"" +
                            ve.PropertyName + ve.ErrorMessage;
                        MessageBox.Show(message2);
                    }
                }
                throw;
            }
        }


    }
}
