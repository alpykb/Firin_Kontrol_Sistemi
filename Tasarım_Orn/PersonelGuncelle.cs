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
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EVG8JA1S;Initial Catalog=firinn;Integrated Security=True");

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }
        private void PersonelListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From PersonelEkleme_Tablosu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PersonelListeleDGV.DataSource = dt;
            
        }

        private void PersonelListeleDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TCTBox.Text = PersonelListeleDGV.CurrentRow.Cells["tc"].Value.ToString();
            AdSoyadTBox.Text = PersonelListeleDGV.CurrentRow.Cells["adsoyad"].Value.ToString();
            TelefonTBox.Text = PersonelListeleDGV.CurrentRow.Cells["telefon"].Value.ToString();
            AdresTBox.Text = PersonelListeleDGV.CurrentRow.Cells["adres"].Value.ToString();
            EmailTBox.Text = PersonelListeleDGV.CurrentRow.Cells["email"].Value.ToString();



        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update PersonelEkleme_Tablosu set adsoyad=@adsoyad, telefon=@telefon, adres=@adres, email=@email where tc=@tc" ,baglanti);
            komut.Parameters.AddWithValue("@tc", TCTBox.Text);
            komut.Parameters.AddWithValue("@adsoyad", AdSoyadTBox.Text);
            komut.Parameters.AddWithValue("@telefon", TelefonTBox.Text);
            komut.Parameters.AddWithValue("@adres", AdresTBox.Text);
            komut.Parameters.AddWithValue("@email", EmailTBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            PersonelListeleDGV.Refresh();
            PersonelListele();
            MessageBox.Show("Personel Kaydı Güncellendi.");
            
            TCTBox.Text = "";
            AdSoyadTBox.Text = "";
            TelefonTBox.Text = "";
            AdresTBox.Text = "";
            EmailTBox.Text = "";
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from PersonelEkleme_Tablosu where tc='" + PersonelListeleDGV.CurrentRow.Cells["tc"].Value.ToString() +"'" ,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            PersonelListeleDGV.Refresh();
            PersonelListele();
            MessageBox.Show("Kayıt Silindi.");

            TCTBox.Text = "";
            AdSoyadTBox.Text = "";
            TelefonTBox.Text = "";
            AdresTBox.Text = "";
            EmailTBox.Text = "";

        }

        private void tcAraTBox_TextChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From PersonelEkleme_Tablosu where tc like '%" + tcAraTBox.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds= new DataSet();
            da.Fill(ds);
            PersonelListeleDGV.DataSource = ds.Tables[0];
            baglanti.Close();
            

        }

        private void AnamenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
