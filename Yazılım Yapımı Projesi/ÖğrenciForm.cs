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
    public partial class ÖğrenciForm : Form
    {
        static DateTime dt = new DateTime();
        static string SqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YazılımYapımıProje\DB\YazılımYapımıDB.mdf;Integrated Security=True;Connect Timeout=30";
        static string bugün;

        public ÖğrenciForm()
        {
            InitializeComponent();

        }

        private void ÖğrenciForm_Load(object sender, EventArgs e)
        {
            // bu günün zamanı tutulur.
            dt = System.DateTime.Today;
            bugün = dt.ToString("d");

            lblZaman.Text = dt.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SınavEkranı sınavEkranı = new SınavEkranı();
            sınavEkranı.Show();
            //gunluksinav();
            // günlük kota kontrolu fonksiyonu çalıştırılır.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();

            ayarlar.Show();
        }

        public void gunluksinav()
        {
            DataTable dtb1 = new DataTable();
            string query4 = "select * from SigmaTimer";
            SqlDataAdapter sda = new SqlDataAdapter(query4, SqlPath);

            sda.Fill(dtb1);
            //databaseden en son test yapılan tarihin bilgisi çekilir.

            if (dtb1.Rows[0]["isAvailable"].ToString() != dt.ToString("d"))
            {// eğer bilgiler eşleşmez ise sınav gerçekleştirilir.
                SınavEkranı sınavEkranı = new SınavEkranı();
                sınavEkranı.Show(); 

                SqlConnection baglanti = new SqlConnection(SqlPath);
                baglanti.Open();

                string sorgu2 = "UPDATE  SigmaTimer set isAvailable = '"+ bugün +"'";

                SqlCommand komut = new SqlCommand(sorgu2, baglanti);
                komut.ExecuteNonQuery();

               

            }
            else
            {
                //eşleşir ise uyarı mesajı çıkar.
                MessageBox.Show("Günlük Kotanızı Doldurdunuz.");
            }
        }

    }
}
