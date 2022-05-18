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

namespace Yazılım_Yapımı_Projesi
{
   
    public partial class SignForm : Form
    {

        static string SqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YazılımYapımıProje\DB\YazılımYapımıDB.mdf;Integrated Security=True;Connect Timeout=30";
        public SignForm()
        {
            InitializeComponent();
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(SqlPath);
            baglanti.Open();
            string sorgu = "INSERT INTO UserData(UserName,Name,Surname,Mail,Password,UserTypeName) VALUES (@userName,@name,@surName,@mail,@password,@userType)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@userName", tbUsername.Text);
            komut.Parameters.AddWithValue("@name", tbName.Text);
            komut.Parameters.AddWithValue("@surName", tbSurname.Text);
            komut.Parameters.AddWithValue("@mail", tbMail.Text);
            komut.Parameters.AddWithValue("@password", tbPassword.Text);
            komut.Parameters.AddWithValue("@userType", cbUserType.SelectedItem);

            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla kayıt edildi.");
        }

        private void SignForm_Load(object sender, EventArgs e)
        {

        }
    }

    
    
}
