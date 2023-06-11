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
    public partial class Stok_Takibi : Form
    {
        public Stok_Takibi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EVG8JA1S;Initial Catalog=firinn;Integrated Security=True");

         void UrunListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From UrunKaydı_Tablosu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            UrunListeleDGV.DataSource = dt;
        }
        private void Stok_Takibi_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into UrunKaydı_Tablosu (Urun_Kodu, Urun_Adi, Fiyat, Kategori, Urun_Miktari) values (@p1, @p2, @p3, @p4, @p5)",baglanti);
            komut.Parameters.AddWithValue("@p1", UrunKoduTBox.Text);
            komut.Parameters.AddWithValue("@p2", UrunAdiTBox.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse (UrunFiyatTBox.Text));
            komut.Parameters.AddWithValue("@p4", KategoriTBox.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(MiktarTBox.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListele();
            UrunKoduTBox.Clear();
            UrunAdiTBox.Clear();
            UrunFiyatTBox.Clear();
            KategoriTBox.Clear();
            MiktarTBox.Clear();





        }

        private void AnamenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm= new AnaForm();
            anaForm.ShowDialog();
        }

        private void UrunListeleDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UrunKoduTBox.Text = UrunListeleDGV.CurrentRow.Cells["Urun_Kodu"].Value.ToString();
            UrunAdiTBox.Text = UrunListeleDGV.CurrentRow.Cells["Urun_Adi"].Value.ToString();
            UrunFiyatTBox.Text = UrunListeleDGV.CurrentRow.Cells["Fiyat"].Value.ToString();
            KategoriTBox.Text = UrunListeleDGV.CurrentRow.Cells["Kategori"].Value.ToString();
            MiktarTBox.Text = UrunListeleDGV.CurrentRow.Cells["Urun_Miktari"].Value.ToString();



        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update UrunKaydı_Tablosu set Urun_Adi=@urunadi, Fiyat=@fiyat, Kategori=@kategori, Urun_Miktari=@UrunMiktari where Urun_Kodu=@urunkodu", baglanti);
            komut.Parameters.AddWithValue("@urunkodu", UrunKoduTBox.Text);
            komut.Parameters.AddWithValue("@urunadi", UrunAdiTBox.Text);
            komut.Parameters.AddWithValue("@fiyat", UrunFiyatTBox.Text);
            komut.Parameters.AddWithValue("@kategori", KategoriTBox.Text);
            komut.Parameters.AddWithValue("@UrunMiktari", MiktarTBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            UrunListeleDGV.Refresh();
            UrunListele();
            MessageBox.Show("Urun  Kaydı Güncellendi.");

            UrunKoduTBox.Text = "";
            UrunAdiTBox.Text = "";
            UrunFiyatTBox.Text = "";
            KategoriTBox.Text = "";
            MiktarTBox.Text = "";
        }

        private void UrunAraTbox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From UrunKaydı_Tablosu where Urun_Kodu like '%" + UrunAraTbox.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            UrunListeleDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
