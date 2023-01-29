using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaYonetimSistemi
{
    public partial class MusteriHesapHaraketleriFrm : Form
    {
        static string conString = "Data Source=localhost;Initial Catalog=BYS;Integrated Security=True";
        static SqlConnection cnn = new SqlConnection(conString);
        public MusteriHesapHaraketleriFrm()
        {
            InitializeComponent();
        }

        private void MusteriHesapHaraketleriFrm_Load(object sender, EventArgs e)
        {
            bilgileriGetir();
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
    }
}
