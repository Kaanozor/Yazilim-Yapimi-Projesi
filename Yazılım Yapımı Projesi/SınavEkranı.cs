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
        static string SqlPath = @"Data Source=DESKTOP-OBA9RNQ\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True";
        static DataTable Questiontbl = new DataTable();
        static int timer = 0;

        

        public SınavEkranı()
        {
            InitializeComponent();
        }





        private void SınavEkranı_Load(object sender, EventArgs e)
        {
          


            SqlConnection sqlcon = new SqlConnection(SqlPath);
            string query = "select top 10 * from QuestionData where SigmaTimer = 0 order by newid()";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            
            sda.Fill(Questiontbl);


            try
            {
                rtbSoruYükle.LoadFile(Questiontbl.Rows[timer]["Path"].ToString(), RichTextBoxStreamType.RichText);
            }
            catch
            {
                MessageBox.Show("Sınavınız bitmiştir.");
                this.Close();
            }















        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Questiontbl.Rows[timer]["RightAns"].ToString());
            if(Questiontbl.Rows[timer]["RightAns"].ToString() == "A")
            {
               Convert.ToInt32(Questiontbl.Rows[timer]["SigmaTimer"]);

                SqlConnection baglanti = new SqlConnection(SqlPath);
                baglanti.Open();
                string sorgu = "UPDATE  QuestionData set SigmaTimer= SigmaTimer + 1 Where QuestionId = '" + Questiontbl.Rows[timer]["QuestionId"] + "'";
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
                }
                

            }

                 
            

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Questiontbl.Rows[timer]["RightAns"].ToString());
            if (Questiontbl.Rows[timer]["RightAns"].ToString() == "B")
            {
                SqlConnection baglanti = new SqlConnection(SqlPath);
                baglanti.Open();
                string sorgu = "UPDATE  QuestionData set SigmaTimer= SigmaTimer + 1 Where QuestionId = '" + Questiontbl.Rows[timer]["QuestionId"] + "'";
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
                }

            }

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Questiontbl.Rows[timer]["RightAns"].ToString());
            if (Questiontbl.Rows[timer]["RightAns"].ToString() == "C")
            {

                SqlConnection baglanti = new SqlConnection(SqlPath);
                baglanti.Open();
                string sorgu = "UPDATE  QuestionData set SigmaTimer= SigmaTimer + 1 Where QuestionId = '" + Questiontbl.Rows[timer]["QuestionId"] + "'";
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
                }
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Questiontbl.Rows[timer]["RightAns"].ToString());
            if (Questiontbl.Rows[timer]["RightAns"].ToString() == "D")
            {

                SqlConnection baglanti = new SqlConnection(SqlPath);
                baglanti.Open();
                string sorgu = "UPDATE  QuestionData set SigmaTimer= SigmaTimer + 1 Where QuestionId = '" + Questiontbl.Rows[timer]["QuestionId"] + "'";
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
                }
            }
        }
    }
}
