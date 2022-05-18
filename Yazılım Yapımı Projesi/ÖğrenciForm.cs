using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapımı_Projesi
{
    public partial class ÖğrenciForm : Form
    {
        public ÖğrenciForm()
        {
            InitializeComponent();
        }

        private void ÖğrenciForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SınavEkranı sınavEkranı = new SınavEkranı();
            sınavEkranı.Show();
        }
    }
}
