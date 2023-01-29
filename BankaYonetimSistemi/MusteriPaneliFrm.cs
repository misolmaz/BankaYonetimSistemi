using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaYonetimSistemi
{
    public partial class MusteriPaneliFrm : Form
    {
        public MusteriPaneliFrm()
        {
            InitializeComponent();
        }

        private void hesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yeniHesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hesaplarımArasındaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void krediBaşvurusuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borçÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kişiselBilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hesaplarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapAcFrm hesapAcFrm = new HesapAcFrm();
            hesapAcFrm.Name = "hesapAc";
            hesapAcFrm.Text = "Yeni Hesap Aç";
            if (Application.OpenForms["hesapAc"] == null)
            {

                hesapAcFrm.Show();
                hesapAcFrm.MdiParent = this;
            }
        }

        private void paraYatırÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaYatirFrm paraYatirFrm = new ParaYatirFrm();
            paraYatirFrm.Name = "paraYatir";
            paraYatirFrm.Text = "Hesaba Para Yatır / Çek";
            if (Application.OpenForms["paraYatir"] == null)
            {

                paraYatirFrm.Show();
                paraYatirFrm.MdiParent = this;
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            HesapHareketleriFrm hesapHareketleriFrm = new HesapHareketleriFrm();
            hesapHareketleriFrm.Name = "hesapHareketleri";
            hesapHareketleriFrm.Text = "Hesaplarım";
            if (Application.OpenForms["hesapHareketleri"] == null)
            {

                hesapHareketleriFrm.Show();
                hesapHareketleriFrm.MdiParent = this;
            }
        }

        private void paraTransferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HavaleFrm havaleFrm = new HavaleFrm();
            havaleFrm.Name = "havale";
            havaleFrm.Text = "Para Transferi";
            if (Application.OpenForms["havale"] == null)
            {

                havaleFrm.Show();
                havaleFrm.MdiParent = this;
            }
        }

        private void bilgiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriBilgiGuncellemeFrm musteriBilgiGuncellemeFrm = new MusteriBilgiGuncellemeFrm();
            musteriBilgiGuncellemeFrm.Name = "musteriBilgiGuncelleme";
            musteriBilgiGuncellemeFrm.Text = "Bilgi Güncelleme";
            if (Application.OpenForms["musteriBilgiGuncelleme"] == null)
            {

                musteriBilgiGuncellemeFrm.Show();
                musteriBilgiGuncellemeFrm.MdiParent = this;
            }
        }

        private void yeniKrediBaşvurusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediBasvurusuFrm krediBasvurusuFrm = new KrediBasvurusuFrm();
            krediBasvurusuFrm.Name = "krediBasvurusu";
            krediBasvurusuFrm.Text = "Yeni Kredi Başvurusu";
            if (Application.OpenForms["krediBasvurusu"] == null)
            {

                krediBasvurusuFrm.Show();
                krediBasvurusuFrm.MdiParent = this;
            }
        }

        private void krediTaksitiÖdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediOdeFrm krediOdeFrm = new KrediOdeFrm();
            krediOdeFrm.Name = "KrediTaksiti Ödeme";
            if (Application.OpenForms["krediOde"] == null)
            {

                krediOdeFrm.Show();
                krediOdeFrm.MdiParent = this;
            }
        }
    }
}
