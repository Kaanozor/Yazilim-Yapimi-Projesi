﻿using System;
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
    
    public partial class SoruEkleme : Form
    {
        static string SqlPath = @"Data Source=DESKTOP-OBA9RNQ\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True";
        static string filename = "";
        public SoruEkleme()
        {
            InitializeComponent();
        }

        private void SoruEkleme_Load(object sender, EventArgs e)
        {

        }
        public void buttonSoruEkle_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Rich Text File|*.rtf";
            saveDlg.DefaultExt = "*.rtf";
            saveDlg.FilterIndex = 1;
            saveDlg.Title = "İçeriği Kaydet.";
            

            DialogResult retval = saveDlg.ShowDialog();
            if (retval == DialogResult.OK)
                filename = saveDlg.FileName;
            else
                return;

           
            RichTextBoxStreamType stream_type;
            stream_type = RichTextBoxStreamType.RichText;       
            rtbSoruEkle.SaveFile(filename, stream_type);
            MessageBox.Show(filename);
            soruyuKaydet();

        }

        void soruyuKaydet()
        {
            SqlConnection baglanti = new SqlConnection(SqlPath);
            baglanti.Open();
            string sorgu = "INSERT INTO QuestionData(Path,RightAns,UnitID,SectionID) VALUES (@rtf,@RightAns,@UnitId,@SectionId)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@rtf",filename.ToString());
            komut.Parameters.AddWithValue("@UnitId",tbUnit.Text);
              komut.Parameters.AddWithValue("@SectionId",tbBölüm.Text);
            komut.Parameters.AddWithValue("@RightAns",cbRightAns.SelectedItem);
            komut.ExecuteNonQuery();
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtbSoruEkle.SelectionFont = fontDialog1.Font;
        }

        private void buttonRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtbSoruEkle.SelectionColor = colorDialog1.Color;
        }
    }
}
