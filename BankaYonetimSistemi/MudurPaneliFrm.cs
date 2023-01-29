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
    public partial class MudurPaneliFrm : Form
    {
        static string conString = "Data Source=localhost;Initial Catalog=BYS;Integrated Security=True";
        static SqlConnection cnn = new SqlConnection(conString);
        kullanicilar updates;
        parabirimi updateParaBirimi;
        ayarlar updateAyarlar;
        int selectId;
        public MudurPaneliFrm()
        {
            InitializeComponent();
        }

        private void MudurPaneliFrm_Resize(object sender, EventArgs e)
        {
            tabControlMudur.Left = 0;
            tabControlMudur.Top = 0;
            tabControlMudur.Width = this.Width;
            tabControlMudur.Height = this.Height;
        }

        private void MudurPaneliFrm_Load(object sender, EventArgs e)
        {
            tabControlMudur.Left = 0;
            tabControlMudur.Top = 0;
            tabControlMudur.Width = this.Width;
            tabControlMudur.Height = this.Height;
            kullaniciListesi();
            kullaniciTurleri();
            temsilciler();
            parabirimleri();
            ayarlariGetir();

        }

        private void kullaniciListesi ()
        {
            BYSEntities context = new BYSEntities();

          

            dgwListe.DataSource = context.kullanicilar.ToList();
           
        }

        private void parabirimleri()
        {
            BYSEntities context = new BYSEntities();
            dgwKurlar.DataSource = context.parabirimi.ToList();
        }

        private void ayarlariGetir()
        {
            BYSEntities context = new BYSEntities();
            dgwAyarlar.DataSource = context.ayarlar.ToList();
        }
        private void kullaniciTurleri()
        {
            BYSEntities context = new BYSEntities();
            List<kullanicituru> liste = context.kullanicituru.ToList();
            cmbRol.DataSource = liste;
            cmbRol.ValueMember = "rolID";
            cmbRol.DisplayMember = "roladi";
        }

        private void temsilciler()
        {
            BYSEntities context = new BYSEntities();
            List<kullanicilar> liste = context.kullanicilar.Where(w => w.rolID == 2).ToList();
            cmbTemsilci.DataSource = liste;
            cmbTemsilci.ValueMember = "kID";
            cmbTemsilci.DisplayMember = "ad";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();

           // List<kullanicilar> ssloc = context.kullanicilar.Where(w => w.rolID == 1).ToList();
           Int32 kullaniciTuru = Convert.ToInt32(cmbRol.SelectedValue);
            dgwListe.DataSource = context.kullanicilar.Where(w=>w.rolID==kullaniciTuru).ToList();
        }

        private void temsilciAta(int kullanici,int temsilci)
        {
            BYSEntities context = new BYSEntities();
            temsilciler t = new temsilciler();

            t.kID = kullanici;
            t.temsilciID = temsilci;

            try
            {
                context.temsilciler.Add(t);
                context.SaveChanges();

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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            kullanicilar kullanici = new kullanicilar();

            kullanici.ad = txtAd.Text;
            kullanici.soyad = txtSoyad.Text;
            kullanici.tckn = txtTckn.Text;
            kullanici.telno = txtTelNo.Text;
            kullanici.eposta = txtEposta.Text;
            kullanici.adres = txtAdres.Text;
            kullanici.rolID = (int)cmbRol.SelectedValue;

            try
            {
                context.kullanicilar.Add(kullanici);
                context.SaveChanges();
               

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
            if (kullanici.rolID == 1)
            {
                temsilciAta(kullanici.kID, (int)cmbTemsilci.SelectedValue);
            }
        }

        private void dgwListe_SelectionChanged(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            if (dgwListe.SelectedRows.Count > 0)
            {

                selectId = Convert.ToInt32(dgwListe.SelectedRows[0].Cells[0].Value);

                updates = context.kullanicilar.Find(selectId);
                txtAd.Text = updates.ad;
                txtSoyad.Text = updates.soyad;
                txtTckn.Text = updates.tckn;
                txtTelNo.Text = updates.telno;
                txtEposta.Text = updates.eposta;
                txtAdres.Text = updates.adres;
               

            }
            
        }

        private void btnKurListele_Click(object sender, EventArgs e)
        {
            parabirimleri();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            parabirimi p = new parabirimi();

            p.dovizadi = txtDovizAdi.Text;
            p.kur = Convert.ToDouble(txtKurDegeri.Text);

            try
            {
                context.parabirimi.Add(p);
                context.SaveChanges();
                parabirimleri();


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

        private void dgwKurlar_SelectionChanged(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            if (dgwKurlar.SelectedRows.Count > 0)
            {

                selectId = Convert.ToInt32(dgwKurlar.SelectedRows[0].Cells[0].Value);

                updateParaBirimi = context.parabirimi.Find(selectId);
                txtDovizAdi.Text = updateParaBirimi.dovizadi;
                txtKurDegeri.Text = updateParaBirimi.kur.ToString();
                


            }
        }

        private void btnKurDuzelt_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            updateParaBirimi = context.parabirimi.Find(selectId);
            updateParaBirimi.dovizadi = txtDovizAdi.Text;
            updateParaBirimi.kur =Convert.ToDouble(txtKurDegeri.Text);
           

            context.SaveChanges();
            dgwKurlar.DataSource = context.parabirimi.ToList();
        }

        private void btnKurSil_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            if (dgwKurlar.SelectedRows.Count > 0)
            {
                DialogResult sonuc = MessageBox.Show("Are You Sure to Delete", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in dgwKurlar.SelectedRows)
                    {

                        int id = Convert.ToInt32(item.Cells[0].Value);
                        context.parabirimi.Remove(context.parabirimi.Find(id));
                        context.SaveChanges();
                        MessageBox.Show("Deleted.");
                        dgwKurlar.DataSource = context.parabirimi.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Can't delete.");

                }
            }
        }

        private void dgwAyarlar_SelectionChanged(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            if (dgwAyarlar.SelectedRows.Count > 0)
            {

                selectId = Convert.ToInt32(dgwAyarlar.SelectedRows[0].Cells[0].Value);

                updateAyarlar = context.ayarlar.Find(selectId);
                lblAd.Text = updateAyarlar.ad;
                txtDeger.Text = updateAyarlar.deger.ToString();
                

            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            updateAyarlar = context.ayarlar.Find(selectId);
            updateAyarlar.deger = Convert.ToDouble(txtDeger.Text);
            updateAyarlar.ad = lblAd.Text;


            context.SaveChanges();
            dgwAyarlar.DataSource = context.ayarlar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            dgwKasaHareketleri.DataSource = context.kasaharaketleri.ToList();
            kasaHesapla();
        }

        private void kasaHesapla()
        {
            int bakiye = 0;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                String sorgu = "SELECT * FROM kasaharaketleri ";
                SqlCommand komut = new SqlCommand(sorgu, cnn);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    if ((int)dr[4] == 1)
                    {
                        
                        bakiye += (int)dr["miktar"];
                       
                    }
                    else
                    {
                        bakiye -= (int)dr["miktar"];
                    }
                }

                txtBakiye.Text = bakiye.ToString();
                cnn.Close();
                dr.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu " + hata.Message);
                MessageBox.Show("Bir hata oluştu " + hata.StackTrace);
            }


        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            Degerler.musteriId = selectId;
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
