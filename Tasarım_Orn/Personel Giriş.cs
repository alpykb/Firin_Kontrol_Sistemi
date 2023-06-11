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
    public partial class Personel_Giriş : Form
    {
        public Personel_Giriş()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EVG8JA1S;Initial Catalog=firinn;Integrated Security=True");

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From Giris_Tablosu where KullaniciAdi=@kadi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("kadi", KullaniciAdiTBox.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi",SifreTBox.Text.Trim());
                SqlCommand komut=new SqlCommand(sql,baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt=new DataTable();
                SqlDataAdapter da=new SqlDataAdapter(komut);
                da.Fill(dt);
                this.Hide();


                if (dt.Rows.Count > 0)
                {
                    AnaForm aform = new AnaForm();
                    aform.Show();
                  
                    
                    
                     
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş!");
            }
        }
    }
}
