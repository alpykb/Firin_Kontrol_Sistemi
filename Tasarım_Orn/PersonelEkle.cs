using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tasarım_Orn
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EVG8JA1S;Initial Catalog=firinn;Integrated Security=True");
        
        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into PersonelEkleme_Tablosu (tc,adsoyad, telefon, adres, email) values (@tc, @adsoyad, @telefon, @adres, @email)",baglanti);
            komut.Parameters.AddWithValue("@tc", TCTBox.Text);
            komut.Parameters.AddWithValue("@adsoyad", AdSoyadTBox.Text);
            komut.Parameters.AddWithValue("@telefon", TelefonTBox.Text);
            komut.Parameters.AddWithValue("@adres", AdresTBox.Text);
            komut.Parameters.AddWithValue("@email", EmailTBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydı Eklendi.");
            TCTBox.Text = "";
            AdSoyadTBox.Text = "";
            TelefonTBox.Text = "";
            AdresTBox.Text = "";
            EmailTBox.Text = "";
        }

        private void AnaMenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.ShowDialog();
        }
    }
}
