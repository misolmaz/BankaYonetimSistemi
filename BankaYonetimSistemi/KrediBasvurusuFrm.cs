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
    public partial class KrediBasvurusuFrm : Form
    {
        public KrediBasvurusuFrm()
        {
            InitializeComponent();
        }

        private void KrediBasvurusuFrm_Load(object sender, EventArgs e)
        {
            hesaplarimiListele();
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int miktar = Convert.ToInt32(txtMiktar.Text);
            double vade = Convert.ToDouble(txtVade.Text);
            double faizOrani = faizOgren();


            double a, b, x;
            double taksit;
            a = (1 + faizOrani / 100);
            b = vade;
            x = Math.Pow(a, b);
            x = 1 / x;
            x = 1 - x;
            taksit = (miktar) * (faizOrani / 100) / x;

            //MessageBox.Show(taksit.ToString());
            int sira = 0;
            DateTime vadeTarihi = DateTime.Now;

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

        private double faizOgren()
        {
            double faizOrani = 0;
            BYSEntities context = new BYSEntities();
            
            var ayarlar = context.ayarlar.Single(w => w.ad== "faiz");

            faizOrani =(double) ayarlar.deger; 

            return faizOrani;
        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            int musteriId = Degerler.musteriId;
            krediler kredi = new krediler();

            kredi.hesapID =(int) cmbHesaplar.SelectedValue;
            kredi.miktar = Convert.ToInt32(txtMiktar.Text);
            kredi.vade = Convert.ToInt32(txtVade.Text);
            kredi.tarih = DateTime.Now.ToShortDateString();
            kredi.onay = 0;

            try
            {
                context.krediler.Add(kredi);
                context.SaveChanges();
                MessageBox.Show("Kredi Başvurusu Yapıldı");
                txtMiktar.Text = "";
                txtVade.Text = "";
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
