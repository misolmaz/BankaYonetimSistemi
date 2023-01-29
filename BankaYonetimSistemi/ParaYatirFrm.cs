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
    public partial class ParaYatirFrm : Form
    {
        
        static string conString = "Data Source=localhost;Initial Catalog=BYS;Integrated Security=True";
        static SqlConnection cnn = new SqlConnection(conString);
        public ParaYatirFrm()
        {
            InitializeComponent();
        }

        private void ParaYatirFrm_Load(object sender, EventArgs e)
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
            BYSEntities context = new BYSEntities();
            int hesapId = (int)cmbHesaplar.SelectedValue;
            dgwHesapHaraketleri.DataSource = context.hesapharaketleri.Where(w => w.hesapId == hesapId).ToList();
            hesapBakiyesiHesapla(hesapId);
        }

        private void hesapBakiyesiHesapla(int hesap)
        {
            int bakiye = 0;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                String sorgu = "SELECT * FROM hesapharaketleri where hesapID =" + hesap;
                SqlCommand komut = new SqlCommand(sorgu, cnn);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["islemturu"].ToString() == "1")
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
            }


        }

        private void btnYatir_Click(object sender, EventArgs e)
        {

            BYSEntities context = new BYSEntities();
            hesapharaketleri hesapHareketi = new hesapharaketleri();

            hesapHareketi.hesapId = (int)cmbHesaplar.SelectedValue;
            hesapHareketi.hedefHesapID = 0;
            hesapHareketi.miktar = Convert.ToInt32(txtMiktar.Text);
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

        private void btnÇek_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtMiktar.Text) > Convert.ToInt16(txtBakiye.Text))
            {
                MessageBox.Show("Bu işlem için bakiyeniz yetersizdir");
            }
            else { 
                BYSEntities context = new BYSEntities();
            hesapharaketleri hesapHareketi = new hesapharaketleri();

            hesapHareketi.hesapId = (int)cmbHesaplar.SelectedValue;
            hesapHareketi.hedefHesapID = 0;
            hesapHareketi.miktar = Convert.ToInt32(txtMiktar.Text);
            hesapHareketi.tarih = DateTime.Now.ToShortDateString();
            hesapHareketi.aciklama = txtAciklama.Text;
            hesapHareketi.islemturu = 2;


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
}
