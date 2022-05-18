using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapımı_Projesi
{
    public partial class Ayarlar : Form
    {
        static string SqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YazılımYapımıProje\DB\YazılımYapımıDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Ayarlar()
        {
            InitializeComponent();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection baglanti1 = new SqlConnection(SqlPath);
            baglanti1.Open();
            string sorgu1 = "UPDATE  SigmaTimer set sigma1 = '"+ Convert.ToInt32(ayarlar1.Text)+"'";
            string sorgu2 = "UPDATE  SigmaTimer set sigma2 = '" + Convert.ToInt32(ayarlar2.Text) + "'";
            string sorgu3 = "UPDATE  SigmaTimer set sigma3 = '" + Convert.ToInt32(ayarlar3.Text) + "'";
            string sorgu4 = "UPDATE  SigmaTimer set sigma4 = '" + Convert.ToInt32(ayarlar4.Text) + "'";
            string sorgu5 = "UPDATE  SigmaTimer set sigma5 = '" + Convert.ToInt32(ayarlar5.Text) + "'";
            string sorgu6 = "UPDATE  SigmaTimer set sigma6 = '" + Convert.ToInt32(ayarlar6.Text) + "'";

            SqlCommand komut1 = new SqlCommand(sorgu1, baglanti1);
            komut1.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand(sorgu2, baglanti1);
            komut2.ExecuteNonQuery();
            SqlCommand komut3 = new SqlCommand(sorgu3, baglanti1);
            komut3.ExecuteNonQuery();
            SqlCommand komut4 = new SqlCommand(sorgu4, baglanti1);
            komut4.ExecuteNonQuery();
            SqlCommand komut5 = new SqlCommand(sorgu5, baglanti1);
            komut5.ExecuteNonQuery();
            SqlCommand komut6 = new SqlCommand(sorgu6, baglanti1);
            komut6.ExecuteNonQuery();
           
        }
    }
}
