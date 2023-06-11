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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EVG8JA1S;Initial Catalog=firinn;Integrated Security=True");
        private void SepetListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Sepet_Tablosu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SatisListeleDGV.DataSource = dt;
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select sum(Toplam_Fiyat) from Sepet_Tablosu", baglanti);
                GenelToplamLBL.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                
            }
        }


        private void Kasa_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void UrunKoduTBox_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From UrunKaydı_Tablosu where Urun_Kodu like '" + UrunKoduTBox.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                UrunAdiTBox.Text = read["Urun_Adi"].ToString();
                FiyatTBox.Text = read["Fiyat"].ToString();
            }
            baglanti.Close();

        }

        private void Temizle()
        {
            if (UrunKoduTBox.Text == "")
            {
                foreach (Control item in UrunBilgigroupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != MiktarTBox)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }

        private void AnamenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.ShowDialog();
        }

        bool durum;
        private void UrunKoduKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Sepet_Tablosu", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (UrunKoduTBox.Text == read["Urun_Kodu"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();


        }


        private void EkleBtn_Click(object sender, EventArgs e)
        {
            UrunKoduKontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Sepet_Tablosu (Urun_Kodu, Urun_Adi, Urun_Miktari, Fiyat, Toplam_Fiyat) values (@Urun_Kodu, @Urun_Adi, @Urun_Miktari, @Fiyat, @Toplam_Fiyat)", baglanti);
                komut.Parameters.AddWithValue("@Urun_Kodu", UrunKoduTBox.Text);
                komut.Parameters.AddWithValue("@Urun_Adi", UrunAdiTBox.Text);
                komut.Parameters.AddWithValue("@Urun_Miktari", int.Parse(MiktarTBox.Text));
                komut.Parameters.AddWithValue("@Fiyat", double.Parse(FiyatTBox.Text));
                komut.Parameters.AddWithValue("@Toplam_Fiyat", double.Parse(ToplamFTBox.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Sepet_Tablosu set Urun_Miktari=Urun_Miktari+'"+int.Parse(MiktarTBox.Text)+ "' where Urun_Kodu='" + UrunKoduTBox.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update Sepet_Tablosu set Toplam_Fiyat=Urun_Miktari*Fiyat where Urun_Kodu = '" + UrunKoduTBox.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            
            MiktarTBox.Text = "1";
            SatisListeleDGV.Refresh();
            SepetListele();
            hesapla();
            foreach (Control item in UrunBilgigroupBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (item != MiktarTBox)
                    {
                        item.Text = "";
                    }
                }

            } 


        }

        private void MiktarTBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToplamFTBox.Text = (double.Parse(MiktarTBox.Text) * double.Parse(FiyatTBox.Text)).ToString();

            }
            catch (Exception)
            {

                
            }
        }

        private void FiyatTBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToplamFTBox.Text = (double.Parse(MiktarTBox.Text) * double.Parse(FiyatTBox.Text)).ToString();

            }
            catch (Exception)
            {

                
            }
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Sepet_Tablosu where Urun_Kodu='" + SatisListeleDGV.CurrentRow.Cells["Urun_Kodu"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();            
            MessageBox.Show("Ürün Sepetten Çıkarıldı.");
            SatisListeleDGV.Refresh();
            SepetListele();
            hesapla();
        }
        private void iPtalBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Sepet_Tablosu ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı.");
            SatisListeleDGV.Refresh();
            SepetListele();
            hesapla();
        }
        private void Kasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Sepet_Tablosu ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı.");
            SatisListeleDGV.Refresh();
            SepetListele();
        }

        private void SatisBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SatisListeleDGV.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Satis_Tablosu (Urun_Kodu, Urun_Adi, Urun_Miktari, Fiyat, Toplam_Fiyat) values (@Urun_Kodu, @Urun_Adi, @Urun_Miktari, @Fiyat, @Toplam_Fiyat)", baglanti);
                komut.Parameters.AddWithValue("@Urun_Kodu", SatisListeleDGV.Rows[i].Cells["Urun_Kodu"].Value.ToString());
                komut.Parameters.AddWithValue("@Urun_Adi", SatisListeleDGV.Rows[i].Cells["Urun_Adi"].Value.ToString());
                komut.Parameters.AddWithValue("@Urun_Miktari", int.Parse(SatisListeleDGV.Rows[i].Cells["Urun_Miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@Fiyat", double.Parse(SatisListeleDGV.Rows[i].Cells["Fiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@Toplam_Fiyat", double.Parse(SatisListeleDGV.Rows[i].Cells["Toplam_Fiyat"].Value.ToString()));
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update UrunKaydı_Tablosu set Urun_Miktari=Urun_Miktari-'" + int.Parse(SatisListeleDGV.Rows[i].Cells["Urun_Miktari"].Value.ToString()) + "' where Urun_Kodu='" + SatisListeleDGV.Rows[i].Cells["Urun_Kodu"].Value.ToString() + "' ", baglanti);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Ürün Satıldı.");
                baglanti.Close();
                
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Delete From Sepet_Tablosu ", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            SatisListeleDGV.Refresh();
            SepetListele();
            hesapla();

        }
       
    }
}
