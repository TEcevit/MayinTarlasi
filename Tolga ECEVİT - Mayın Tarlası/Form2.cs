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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblOyuncuAdi.Visible = false;
            lblOyuncuAdi2.Visible = false;
            lblSkor.Visible = false;
            lblSkor2.Visible = false;
            lblSure.Visible = false;
            lblSure2.Visible = false;
        }

        public Form1 anaForm = new Form1();

        Random rnd = new Random();

        public int oyuncuSkoru = 0;
        public int kalanSure = 30;

        public void LabelGoster()
        {
            lblOyuncuAdi.Visible = true;
            lblOyuncuAdi2.Visible = true;
            lblSkor.Visible = true;
            lblSkor2.Visible = true;
            lblSure.Visible = true;
            lblSure2.Visible = true;
        }

        public void OyuncuAdiGoster()
        {
            lblOyuncuAdi2.Text = anaForm.txtOyuncuAdi.Text;
        }

        public void MayinOlustur(int mayinSayisi, int butonX, int butonY)
        {
            int[] mayinlar = new int[mayinSayisi];
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < mayinlar.Length; i++)
            {
                int secilen = rnd.Next(0, butonX * butonY);
                if (mayinlar.Contains(secilen))
                {
                    i--;
                    continue;
                }
                else
                {
                    mayinlar[i] = secilen;
                }
            }

            for (int i = 0; i < butonY*butonX; i++)
            {
                Button btn = new Button();
                btn.Height = 30;
                btn.Width = 30;
                btn.Margin = new Padding();
                btn.Tag = mayinlar.Contains(i);
                flowLayoutPanel1.Controls.Add(btn);

                btn.Click += Btn_Click;              
            }

            flowLayoutPanel1.Height = butonX * 30;
            flowLayoutPanel1.Width = butonY * 30;

            this.Controls.Add(flowLayoutPanel1);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;
            bool durum = (bool)tiklanan.Tag;
            if (durum)
            {
                tiklanan.BackgroundImage = Image.FromFile("mayın.png");
                tiklanan.BackColor = Color.Red;
                tiklanan.BackgroundImageLayout = ImageLayout.Stretch;

                foreach (Button item in flowLayoutPanel1.Controls)
                {
                    bool mayinMi = (bool)item.Tag;
                    if (mayinMi)
                    {
                        timer1.Stop();
                        item.BackgroundImage = Image.FromFile("mayın.png");
                        item.BackColor = Color.Red;
                        item.BackgroundImageLayout = ImageLayout.Stretch;
                        item.Enabled = false;
                    }
                    else
                    {
                        item.Enabled = false;
                        item.BackColor = Color.White;
                    }
                }
            }
            else
            {
                oyuncuSkoru += 3;
                lblSkor2.Text = oyuncuSkoru.ToString();
                tiklanan.Enabled = false;
                tiklanan.BackColor = Color.White;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            lblSure2.Text = kalanSure.ToString();
            if (kalanSure<1)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz Bitti.");
            }
        }

        #region Kolay Oyun

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelGoster();
            OyuncuAdiGoster();
            timer1.Start();

            kalanSure = 30;
            oyuncuSkoru = 0;
            lblSure2.Text = kalanSure.ToString();

            int mayinSayisi = 5;
            int butonX = 5;
            int butonY = 5;

            MayinOlustur(mayinSayisi, butonX, butonY);
        }

        #endregion

        #region Orta Oyun

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelGoster();
            OyuncuAdiGoster();
            timer1.Start();

            kalanSure = 30;
            oyuncuSkoru = 0;
            lblSure2.Text = kalanSure.ToString();

            int mayinSayisi = 21;
            int butonX = 7;
            int butonY = 7;

            MayinOlustur(mayinSayisi, butonX, butonY);
        }


        #endregion

        #region Orta Oyun

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelGoster();
            OyuncuAdiGoster();
            timer1.Start();

            kalanSure = 30;
            oyuncuSkoru = 0;
            lblSure2.Text = kalanSure.ToString();

            int mayinSayisi = 54;
            int butonX = 9;
            int butonY = 9;

            MayinOlustur(mayinSayisi, butonX, butonY);
        }



        #endregion

        #region Ozel Oyun
        private void özelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OzelSecim frm = new OzelSecim();
            frm.gelenEkran = this;
            frm.ShowDialog();

            lblSure2.Text = kalanSure.ToString();
            lblSkor2.Text = oyuncuSkoru.ToString();
        }

        #endregion

        private void temaDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = Color.Black;
            cd.ShowDialog();
            this.BackColor = cd.Color;

        }

        private void btnSkorKaydet_Click(object sender, EventArgs e)
        {
            string yol = "skorlar.txt";
            StreamWriter yazici = new StreamWriter(yol, true);
            string oyuncuSkorKayit = $"{lblOyuncuAdi2.Text}==>{lblSkor2.Text} Puan {DateTime.Now}";
            yazici.WriteLine(oyuncuSkorKayit);
            yazici.Close();
            MessageBox.Show("Oyuncu Skoru Kaydedildi.");
        }

        private void liderlikTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiderlikTablosu lt = new LiderlikTablosu();
            lt.gelenEkran = this;
            lt.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Windows Form Application Was Developed By Tolga ECEVİT");
        }

        private void çToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?","Mayın Tarlası",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (secim==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            this.Close();
            anaForm.Show();
        }
    }
}
