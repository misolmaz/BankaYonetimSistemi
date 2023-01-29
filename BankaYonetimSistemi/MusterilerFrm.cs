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
    public partial class MusterilerFrm : Form
    {
        int selId;
       
        public MusterilerFrm()
        {
            InitializeComponent();
        }

        private void MusterilerFrm_Load(object sender, EventArgs e)
        {
            musteriListele();
        }

        private void musteriListele()
        {
            BYSEntities context = new BYSEntities();
            int temsilciId = Degerler.temsilciId;
            var musteriListesi = (from k in context.kullanicilar
                                join t in context.temsilciler
                                on k.kID equals t.kID

                                where (t.temsilciID == temsilciId)&&(k.rolID==1)
                                select new
                                {

                                    MusteriID = k.kID,
                                    Ad = k.ad,
                                    Soyad = k.soyad,
                                    Tckn = k.tckn,
                                    TelNo = k.telno,
                                    ePosta = k.eposta,
                                    Adres= k.adres,
                                    

                                }).ToList();

            dgwMusterListesi.DataSource = musteriListesi;

        }

        private void dgwMusterListesi_SelectionChanged(object sender, EventArgs e)
        {
            selId = (int)dgwMusterListesi.CurrentRow.Cells["MusteriID"].Value;
            txtAd.Text = dgwMusterListesi.CurrentRow.Cells["Ad"].Value.ToString();
            txtSoyad.Text = dgwMusterListesi.CurrentRow.Cells["Soyad"].Value.ToString();
            txtTckn.Text = dgwMusterListesi.CurrentRow.Cells["Tckn"].Value.ToString();
            txtTelNo.Text = dgwMusterListesi.CurrentRow.Cells["TelNo"].Value.ToString();
            txtEposta.Text= dgwMusterListesi.CurrentRow.Cells["TelNo"].Value.ToString();
            txtEposta.Text= dgwMusterListesi.CurrentRow.Cells["ePosta"].Value.ToString();
           txtAdres.Text = dgwMusterListesi.CurrentRow.Cells["Adres"].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            musteriListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            kullanicilar kullanici = context.kullanicilar.Find(selId); ;
            kullanici.ad = txtAd.Text;
            kullanici.soyad = txtSoyad.Text;
            kullanici.tckn = txtTckn.Text;
            kullanici.telno = txtTelNo.Text;
            kullanici.eposta = txtEposta.Text;
            kullanici.adres = txtAdres.Text;
            try
            {
                context.SaveChanges();
                musteriListele();
                MessageBox.Show("Müşteri Bilgileri Güncellendi");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    string message1 = "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:" +
                        eve.Entry.Entity.GetType().Name + eve.Entry.State;
                    Console.WriteLine(message1);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        string message2 = "- Property: \"{0}\", Error: \"{1}\"" +
                            ve.PropertyName + ve.ErrorMessage;
                        Console.WriteLine(message2);
                    }
                }
                throw;

            }

           
        }

        private void btnHareket_Click(object sender, EventArgs e)
        {
            Degerler.musteriId = selId;
            MusteriHesapHaraketleriFrm musteriHesapHaraketleriFrm = new MusteriHesapHaraketleriFrm();
            musteriHesapHaraketleriFrm.Name = "musteriHesapHaraketleri";
            musteriHesapHaraketleriFrm.Text = "Müşteri Hesap İnceleme";
            if (Application.OpenForms["musteriHesapHaraketleri"] == null)
            {

                musteriHesapHaraketleriFrm.Show();
                
            }
        }
    }
}
