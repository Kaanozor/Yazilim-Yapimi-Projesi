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
    public partial class Form1 : Form
    {
        static string SqlPath = @"Data Source=DESKTOP-OBA9RNQ\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignForm signForm = new SignForm();
            signForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(SqlPath);

            string query = "Select * from UserData Where UserName_ ='" + tbkadi.Text.Trim() + "'and Password_='" + tbsifre.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                DataRow[] result = dtbl.Select("UserType_='Öğrenci'");
                foreach (DataRow row in result)
                {
                    ÖğrenciForm öğrenci = new ÖğrenciForm();
                    this.Hide();
                    öğrenci.Show();

                }
                DataRow[] result1 = dtbl.Select("UserType_='Öğretmen'");
                foreach (DataRow row in result1)
                {
                    SoruEkleme ogretmen = new SoruEkleme();
                    this.Hide();
                    ogretmen.Show();

                }
            }
            else
                MessageBox.Show("Şifre Yanlış.");
            
        }
    }
}
