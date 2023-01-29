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
    public partial class HavaleFrm : Form
    {
        public HavaleFrm()
        {
            InitializeComponent();
        }

        private void HavaleFrm_Load(object sender, EventArgs e)
        {
            hesaplarimiListele();
            kullaniciListele();
        }

        private void hesaplarimiListele()
        {
            BYSEntities context = new BYSEntities();
            int musteriId = Degerler.musteriId;
            var hesaplistesi = (from n in context.hesaplar
                                join p in context.parabirimi
                                on n.dovizID equals p.dovizID

                                where (n.onayli == "1") && (n.kID == musteriId)
                                select new
                                {

                                    hesapId = n.hesapID,
                                    ParaBirimi = p.dovizadi,


                                }).ToList();
            cmbHesaplar.DataSource = hesaplistesi;
            cmbHesaplar.DisplayMember = "ParaBirimi";
            cmbHesaplar.ValueMember = "hesapId";
        }

        private void kullaniciListele()
        {
            BYSEntities context = new BYSEntities();


            cmbHedefMusteri.DataSource = context.kullanicilar.Where(w => w.rolID == 1).ToList();
            cmbHedefMusteri.DisplayMember = "ad";
            cmbHedefMusteri.ValueMember = "kID";
        }

        private void hedefHesapListele()
        {
            try
            {
                BYSEntities context = new BYSEntities();
                int musteriId = (int)cmbHedefMusteri.SelectedValue;
                var hesaplistesi = (from n in context.hesaplar
                                    join p in context.parabirimi
                                    on n.dovizID equals p.dovizID

                                    where (n.onayli == "1") && (n.kID == musteriId)
                                    select new
                                    {

                                        hesapId = n.hesapID,
                                        ParaBirimi = p.dovizadi,


                                    }).ToList();
                CmbHedefHesap.DataSource = hesaplistesi;
                CmbHedefHesap.DisplayMember = "ParaBirimi";
                CmbHedefHesap.ValueMember = "hesapId";
            }
            catch { }
        }

        private void cmbHedefMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            hedefHesapListele();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            int tutar;
            if (cmbHesaplar.Text != CmbHedefHesap.Text)
            {
                tutar = parabirimiDonustur();
                // MessageBox.Show(convertMiktar.ToString());
            }
            else
            {
                tutar = Convert.ToInt16(txtMiktar.Text);
            }
            havaleCikisi();
            havaleAktarimi(tutar);
            MessageBox.Show("Havale gönderildi");
            txtMiktar.Text = "";
            txtAciklama.Text = "";

        }
        private void havaleAktarimi(int tutar)
        {
            BYSEntities context = new BYSEntities();
            hesapharaketleri hesapHareketi = new hesapharaketleri();

            hesapHareketi.hesapId = (int)CmbHedefHesap.SelectedValue;
            hesapHareketi.hedefHesapID = (int)cmbHesaplar.SelectedValue;
            hesapHareketi.miktar = tutar;
            hesapHareketi.tarih = DateTime.Now.ToShortDateString();
            hesapHareketi.aciklama = txtAciklama.Text;
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

        private int parabirimiDonustur()
        {
            int yeniKur = 0;
            double kurDegeri = 0;
            BYSEntities context = new BYSEntities();
            string dovizTuru;
            if (cmbHesaplar.Text.Trim() == "TL")
            {
                dovizTuru = CmbHedefHesap.Text;
                var kurlar = context.parabirimi.Single(w => w.dovizadi == dovizTuru);

                kurDegeri = (double)kurlar.kur;
            }
            else
            {
                dovizTuru = cmbHesaplar.Text;
                var kurlar = context.parabirimi.Single(w => w.dovizadi == dovizTuru);

                kurDegeri = (double)kurlar.kur;

            }

            // MessageBox.Show(kurDegeri.ToString());
            if (cmbHesaplar.Text.Trim() == "TL")
            {
                yeniKur = (int)(Convert.ToInt16(txtMiktar.Text) / kurDegeri);
            }
            else
            {
                yeniKur = (int)(Convert.ToInt16(txtMiktar.Text) * kurDegeri);
            }
            return yeniKur;
        }


        private void havaleCikisi()
        {

            BYSEntities context = new BYSEntities();
            hesapharaketleri hesapHareketi = new hesapharaketleri();

            hesapHareketi.hesapId = (int)cmbHesaplar.SelectedValue;
            hesapHareketi.hedefHesapID = (int)CmbHedefHesap.SelectedValue;
            hesapHareketi.miktar = Convert.ToInt32(txtMiktar.Text);
            hesapHareketi.tarih = DateTime.Now.ToShortDateString();
            hesapHareketi.aciklama = txtAciklama.Text;
            hesapHareketi.islemturu = 3;


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
