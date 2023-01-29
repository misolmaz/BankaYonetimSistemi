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
    public partial class MusteriBilgiGuncellemeFrm : Form
    {
        public MusteriBilgiGuncellemeFrm()
        {
            InitializeComponent();
        }

        private void MusteriBilgiGuncellemeFrm_Load(object sender, EventArgs e)
        {
            bilgileriGetir();
        }

        private void bilgileriGetir()
        {
           
            BYSEntities context = new BYSEntities();
            
            int musteriId = Degerler.musteriId;
          
            var kullanici = context.kullanicilar.Single(w => w.kID == musteriId);

            txtAd.Text = kullanici.ad;
            txtSoyad.Text = kullanici.soyad;
            txtTckn.Text = kullanici.tckn;
            txtEposta.Text = kullanici.eposta;
            txtAdres.Text = kullanici.adres;
            txtTelNo.Text = kullanici.telno;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            int musteriId = Degerler.musteriId;
            kullanicilar kullanici = context.kullanicilar.Find(musteriId); ;
            kullanici.tckn = txtTckn.Text;
            kullanici.telno = txtTelNo.Text;
            kullanici.eposta = txtEposta.Text;
            kullanici.adres = txtAdres.Text;
            try
            {
                context.SaveChanges();
                bilgileriGetir();
                MessageBox.Show("Müşteri Bilgileri Güncellendi");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    string message1= "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:"+
                        eve.Entry.Entity.GetType().Name+ eve.Entry.State;
                    Console.WriteLine(message1);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        string message2= "- Property: \"{0}\", Error: \"{1}\""+
                            ve.PropertyName + ve.ErrorMessage;
                        Console.WriteLine(message2);
                    }
                }
                throw;

            }
        }
    }
}
