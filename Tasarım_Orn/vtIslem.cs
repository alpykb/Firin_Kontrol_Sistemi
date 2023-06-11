using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Tasarım_Orn
{
    internal class vtIslem
    {
        #region Değişken ve Tanımlamalar
        static SqlConnection fırınConn = new SqlConnection(vtBaglanti.vtAdres);
        static SqlDataAdapter fırınAdp;
        static SqlCommand fırınCmd = new SqlCommand();
        #endregion

        #region Kullanıcı Tanımlı Olaylar
       public static DataTable veriGetir(string sorgu)
        {
            DataTable fırınTablo = new DataTable();
            fırınAdp = new SqlDataAdapter(sorgu, fırınConn);
            fırınAdp.Fill(fırınTablo);
            return fırınTablo;
        }

        public void komutCalistir(string komut)
        {
            try
            {
                if (fırınConn.State == ConnectionState.Closed)
                    fırınConn.Open();
                fırınCmd.Connection = fırınConn;
                fırınCmd.CommandText = komut;
                fırınCmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), "Bilgi",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
             
            }
            finally
            {
                fırınConn.Close();
            }
        }
        #endregion


    }
}
