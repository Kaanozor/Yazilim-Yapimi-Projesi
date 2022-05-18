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
        static string SqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YazılımYapımıProje\DB\YazılımYapımıDB.mdf;Integrated Security=True;Connect Timeout=30";
        static public void SigmaSorularıSec()
        {
            SqlConnection sqlcon = new SqlConnection(SqlPath);
            string query = "select top 10 * from QuestionData where SigmaDate = '"+ DateTime.Today.ToString() +"'  order by newid()";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

        }

        static public void SigmaSorularınıKaydet(int Id)
        {
        }

       static public void YanlısSorularıKaydet(int Id)
        {

        }

    }
}
