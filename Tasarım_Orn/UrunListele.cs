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
    public partial class UrunListele : Form
    {
        public UrunListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EVG8JA1S;Initial Catalog=firinn;Integrated Security=True");
        void UrunListelee()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From UrunKaydı_Tablosu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            UrunListeleDGV.DataSource = dt;
        }


        private void AnamenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
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

        private void UrunListele_Load(object sender, EventArgs e)
        {
            UrunListelee();
        }

        private void tcAraTBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From UrunKaydı_Tablosu where Urun_Kodu like '%" + UrunAraTbox.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            UrunListeleDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
