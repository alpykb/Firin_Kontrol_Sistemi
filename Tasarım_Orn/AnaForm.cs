using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasarım_Orn
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            //Application.Run(new Personel_Giriş());
        }
        #region Değişkenler ve tanımlamalar

        #endregion

        #region Kullanıcı Tanımlı Olaylar


        #endregion

        #region Nesne Tanımlı Olaylar
        public void AnaForm_Load(object sender, EventArgs e)
        {
         
        }
        
        

        #endregion

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ürünKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Stok_Takibi urunkaydi = new Stok_Takibi();
            urunkaydi.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Stok_Takibi urunkaydi = new Stok_Takibi();
            urunkaydi.Show();            
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            PersonelEkle ekle =new PersonelEkle();
            ekle.Show();

        }

        private void personelListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            PersonelGuncelle personelGuncelle =new PersonelGuncelle();
            personelGuncelle.ShowDialog();
        }

        private void satılanListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            SatisListe liste = new SatisListe();
            liste.Show();
        }

        private void satışSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Kasa kasa = new Kasa();
            kasa.Show();
            
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            UrunListele urunliste = new UrunListele();
            urunliste.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Stok_Takibi urunkaydi = new Stok_Takibi();
            urunkaydi.Show();
        }
    }
}
