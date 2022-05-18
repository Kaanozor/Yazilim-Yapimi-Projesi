using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Yapımı_Projesi
{ 


    static class Sigma
    {
        static string SqlPath = @"Data Source = DESKTOP - OBA9RNQ\SQLEXPRESS;Initial Catalog = YazılımYapımı; Integrated Security = True";
        static public void GunlukSoruSec()
            
        {
            SqlConnection sqlcon = new SqlConnection(SqlPath);
            string query = "select top 10 * from QuestionData where SigmaTimer = 0 order by newid()";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            SınavEkranı sınav = new SınavEkranı();
            


        }

       static public void SigmaSorularıSec()
        { 


        }

        static public void SigmaSorularınıKaydet(int Id)
        {
        }

       static public void YanlısSorularıKaydet(int Id)
        {

        }

    }
}
