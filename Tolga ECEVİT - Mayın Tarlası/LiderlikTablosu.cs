using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolga_ECEVİT___Mayın_Tarlası
{
    public partial class LiderlikTablosu : Form
    {
        public LiderlikTablosu()
        {
            InitializeComponent();
        }

        public Form2 gelenEkran = new Form2();
        private void LiderlikTablosu_Load(object sender, EventArgs e)
        {
            string dosyaYolu = "skorlar.txt";

            StreamReader okuyucu = new StreamReader(dosyaYolu);

            string skorlar = okuyucu.ReadToEnd();
            richTextBox1.Text = skorlar;
            okuyucu.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
