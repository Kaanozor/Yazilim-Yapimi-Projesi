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


    


    public partial class SınavEkranı : Form
    {
        static string SqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YazılımYapımıProje\DB\YazılımYapımıDB.mdf;Integrated Security=True;Connect Timeout=30";
        static DataTable Questiontbl = new DataTable();
        static int timer = 0;
        static string bugün;

        DateTime dt = new DateTime();



        public SınavEkranı()
        {
            InitializeComponent();
        }





        private void SınavEkranı_Load(object sender, EventArgs e)
        {
            



            dt = System.DateTime.Today;
            bugün = (dt.ToString("yyyy-MM-dd"));
            BaşlangıçSoruGetir();


        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            Soru("A");
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            Soru("B");

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Soru("C");
        }

        private void buttonD_Click(object sender, EventArgs e)
        {

            Soru("D");
     
        } 


       



        public void BaşlangıçSoruGetir()
        {
            //Günlük daha önce çözülmemiş 10 rastgele soruyu öğrenciye getirir.
            //Tarihte bugün olan Sigma Sorularını getirir.
            SqlConnection sqlcon = new SqlConnection(SqlPath);
            string query = "select top 10 * from QuestionData where SigmaTimer = 0 order by newid()";
            string query2 = "select * from QuestionData where SigmaDate = '"+bugün+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon);
            sda2.Fill(Questiontbl);
            sda.Fill(Questiontbl);


            rtbSoruYükle.LoadFile(Questiontbl.Rows[timer]["Path"].ToString(), RichTextBoxStreamType.RichText);





        }

        public void SigmaDater()
        {
            // doğru bilinen sorular için öncelikle ne kadar sonra soracağımız ile ilgili verileri tutan değerler çağrılır.

            SqlConnection baglanti1 = new SqlConnection(SqlPath);
            baglanti1.Open();

            string query = "Select * from SigmaTimer";
            SqlDataAdapter sda = new SqlDataAdapter(query, SqlPath);
            DataTable dtbl1 = new DataTable();
            sda.Fill(dtbl1);

            int sigma1 = Convert.ToInt32(dtbl1.Rows[0]["sigma1"]);
            int sigma2 = Convert.ToInt32(dtbl1.Rows[0]["sigma2"]);
            int sigma3 = Convert.ToInt32(dtbl1.Rows[0]["sigma3"]);
            int sigma4 = Convert.ToInt32(dtbl1.Rows[0]["sigma4"]);
            int sigma5 = Convert.ToInt32(dtbl1.Rows[0]["sigma5"]);
            int sigma6 = Convert.ToInt32(dtbl1.Rows[0]["sigma6"]);

            //çağrılan verilen int'lere atanır.
            
            switch (Convert.ToInt32(Questiontbl.Rows[timer]["SigmaTimer"]))
            {//doğru bilinen cevabın sahip olduğu sigma değerine göre ne kadar sonra sorulacağı ayarlanır.
               
                    
                    
                case 0:
                    MessageBox.Show("sa1");
                 bugün =   dt.AddDays(sigma1).ToString("yyyy-MM-dd");
                    MessageBox.Show(bugün);
                    //eğer sigma değeri 0 ise sigma1' verisi kadar ileri tarihe atanır.
                    break;
                case 1:
                    MessageBox.Show("sa2");
                    bugün = dt.AddDays(sigma2).ToString("yyyy-MM-dd");
                    MessageBox.Show(bugün);
                    break;
                case 2:
                    MessageBox.Show("sa3");
                    bugün = dt.AddDays(sigma3).ToString("yyyy-MM-dd");
                    MessageBox.Show(bugün);
                    break;
                case 3:
                    MessageBox.Show("sa4");
                    bugün = dt.AddDays(sigma4).ToString("yyyy-MM-dd");
                    MessageBox.Show(bugün);
                    break;
                case 4:
                    MessageBox.Show("sa5");
                    bugün = dt.AddDays(sigma5).ToString("yyyy-MM-dd");
                    MessageBox.Show(bugün);
                    break;
                case 5:
                    MessageBox.Show("sa6");
                    bugün = dt.AddDays(sigma6).ToString("yyyy-MM-dd");
                    MessageBox.Show(bugün);
                    break;


            }

             //bugün değeri bir sayaç olarak kullanılıri artırıldıktan sonra komut için kullanılır ve sonra sıfırlanır
            string sorgu2 = "UPDATE  QuestionData set SigmaDate = '" + bugün + "' Where QuestionId = '" + Questiontbl.Rows[timer]["QuestionId"] + "'";

            






            SqlCommand komut = new SqlCommand(sorgu2, baglanti1);
            komut.ExecuteNonQuery();
            bugün = "";


        }
    public void Soru(string Cevap)
        {
            //sorular çözüldükçe veritabanında  Sigma değerleri artar veya sıfırlanır.
            
            if (Questiontbl.Rows[timer]["RightAns"].ToString() == Cevap)
            {
                SigmaDater();
                //soru sigma işleminden geçtikten sonra hangi soruda kaldığımızı tutan timer verisi bir artar

                
                timer++;


                try
                {
                    //yeni soruyu yüklemeye çalış, eğer yeni soru yok ise sınav bitmiştir.

                    rtbSoruYükle.LoadFile(Questiontbl.Rows[timer]["Path"].ToString(), RichTextBoxStreamType.RichText);
                }
                catch
                {
                    MessageBox.Show("Sınavınız bitmiştir.");
                    this.Close();
                    
                }





            }
            else
            { 
                //soru yanlış bilinir ise sigma değeri sıfırlanır.
                SqlConnection baglanti = new SqlConnection(SqlPath);
                baglanti.Open();
                string sorgu = "UPDATE  QuestionData set SigmaTimer= 0 Where QuestionId = '" + Questiontbl.Rows[timer]["QuestionId"] + "'";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                timer++;

                try
                {
                    rtbSoruYükle.LoadFile(Questiontbl.Rows[timer]["Path"].ToString(), RichTextBoxStreamType.RichText);
                }
                catch
                {
                    MessageBox.Show("Sınavınız bitmiştir.");
                    this.Close();
                    baglanti.Close();
                }
            }

        }
    }
}
