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
    public partial class HesapAcFrm : Form
    {
        public HesapAcFrm()
        {
            InitializeComponent();
        }

        private void HesapAcFrm_Load(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();

            List<parabirimi> liste = context.parabirimi.ToList();

            cmbDoviz.DataSource = liste;
            cmbDoviz.ValueMember = "dovizID";
            cmbDoviz.DisplayMember = "dovizadi";
        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {
            BYSEntities context = new BYSEntities();
            hesaplar hesap = new hesaplar();

            hesap.dovizID = (int)cmbDoviz.SelectedValue;
            hesap.kID = Degerler.musteriId;
            hesap.onayli = "0";

            try
            {
                context.hesaplar.Add(hesap);
                context.SaveChanges();
                MessageBox.Show("Başvuru Yapıldı");



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
