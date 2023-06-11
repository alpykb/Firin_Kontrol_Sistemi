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
    public partial class SatisListe : Form
    {
        public SatisListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EVG8JA1S;Initial Catalog=firinn;Integrated Security=True");
        private void SatisListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Satis_Tablosu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SatisDGV.DataSource = dt;
        }
        private void SatisListe_Load(object sender, EventArgs e)
        {
            SatisListele();
        }

        private void AnamenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.ShowDialog();
        }
    }
}
