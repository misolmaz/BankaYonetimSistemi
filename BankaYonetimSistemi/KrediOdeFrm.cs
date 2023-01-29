using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaYonetimSistemi
{
    public partial class KrediOdeFrm : Form
    {
        static string conString = "Data Source=localhost;Initial Catalog=BYS;Integrated Security=True";
        static SqlConnection cnn = new SqlConnection(conString);
        int krediNo = 0;
        int hesapNo = 0;
        public KrediOdeFrm()
        {
            InitializeComponent();
        }

        private void KrediOdeFrm_Load(object sender, EventArgs e)
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

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            int miktar = 0, vade = 0;
            DateTime ilkVade = DateTime.Now;

            BYSEntities context = new BYSEntities();

            int hesap =(int) cmbHesaplar.SelectedValue;
            var kredi = (from h in context.hesaplar
                                join k in context.krediler
                                on h.hesapID equals k.hesapID

                                where (k.onay == 1) && (k.hesapID == hesap)
                                select new
                                {

                                    miktar = k.miktar,
                                    vade = k.vade,
                                    ilkVade = k.tarih,
                                    krediNo = k.krediID,
                                    hesapNo =k.hesapID,


                                }).ToList();
            if (kredi.Capacity > 0)
            {
                miktar = kredi[0].miktar;
                vade = kredi[0].vade;
                krediNo = kredi[0].krediNo;

                int odeneneTaksitSayisi = odemeSay();
                vade -= odeneneTaksitSayisi;
                ilkVade = ilkVade.AddMonths(odeneneTaksitSayisi);
                taksitYaz(miktar, vade, ilkVade);
            }

        }

        private int odemeSay()
        {
            int odemeSayisi = 0;
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            string sorgu = "Select  Count(*) from kasaharaketleri where islemturu=1 AND krediID=" + krediNo;
            // SELECT temsilciID, COUNT(temsilciID) FROM temsilciler GROUP BY temsilciID"
            SqlCommand komut = new SqlCommand(sorgu, cnn);
            odemeSayisi = (int)komut.ExecuteScalar();
            //MessageBox.Show(" Odenen taksit Sayısı " + odemeSayisi);

            return odemeSayisi;
        }

        private double faizOgren()
        {
            double faizOrani = 0;
            BYSEntities context = new BYSEntities();

            var ayarlar = context.ayarlar.Single(w => w.ad == "faiz");

            faizOrani = (double)ayarlar.deger;

            return faizOrani;
        }

        private void taksitYaz(int miktar, int vade, DateTime ilk)
        {

            double faizOrani = faizOgren();


            double a, b, x;
            int taksit;
            a = (1 + faizOrani / 100);
            b = vade;
            x = Math.Pow(a, b);
            x = 1 / x;
            x = 1 - x;
            taksit = (int)Math.Round((miktar) * (faizOrani / 100) / x);

            //MessageBox.Show(taksit.ToString());
            int sira = 0;
            DateTime vadeTarihi = ilk;

            DataTable dt = new DataTable();
            dt.Columns.Add("sira");
            dt.Columns.Add("Vade_Tarihi");
            dt.Columns.Add("taksit");
            while (sira < vade)
            {
                sira++;
                String strVadeTarihi = vadeTarihi.AddMonths(sira).ToShortDateString();
                DataRow dr = dt.NewRow();
                dr["sira"] = sira;
                dr["Vade_Tarihi"] = strVadeTarihi;
                dr["taksit"] = taksit;
                dt.Rows.Add(dr);
            }

            dgwTaksitler.DataSource = dt;




        }

        private void dgwTaksitler_SelectionChanged(object sender, EventArgs e)
        {
            txtTaksit.Text = dgwTaksitler.CurrentRow.Cells["taksit"].Value.ToString();
            txtVadeTarihi.Text = dgwTaksitler.CurrentRow.Cells["Vade_Tarihi"].Value.ToString();
        }

        private void krediOde()
        {
            BYSEntities context = new BYSEntities();
            hesapharaketleri hesapHareketi = new hesapharaketleri();

            hesapHareketi.hesapId = (int) cmbHesaplar.SelectedValue;
            hesapHareketi.hedefHesapID = 0;
            hesapHareketi.miktar = Convert.ToInt32(txtTaksit.Text);
            hesapHareketi.tarih = DateTime.Now.ToShortDateString();
            hesapHareketi.aciklama = "Kredi Ödemesi";
            hesapHareketi.islemturu = 4;


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


        private void kasaKaydi()
        {
            BYSEntities context = new BYSEntities();
            kasaharaketleri krediOdeme = new kasaharaketleri();

            krediOdeme.krediID = krediNo;
            krediOdeme.hesapID =(int) cmbHesaplar.SelectedValue;
            krediOdeme.miktar = Convert.ToInt32(txtTaksit.Text);
            krediOdeme.tarih = DateTime.Now.ToShortDateString();
            krediOdeme.aciklama = "Kredi Tahsilatı";
            krediOdeme.islemturu = 1;


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

        private void button1_Click(object sender, EventArgs e)
        {
            krediOde();
            kasaKaydi();
            MessageBox.Show("Kredi Ödemesi Gerçekleşti");
        }
    }
}
