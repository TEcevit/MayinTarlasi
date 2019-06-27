using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolga_ECEVİT___Mayın_Tarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerStart.Enabled = true;
            this.Opacity = 0.0;
            lblEksikKullaniciAdi.Visible = false;
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timerStart.Enabled = false;
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            lblEksikKullaniciAdi.Visible = true;
            Form2 frm = new Form2();
            frm.anaForm = this;

            if (!string.IsNullOrEmpty(txtOyuncuAdi.Text))
            {
                this.Hide();
                frm.Show();
            }
            else
            {
                lblEksikKullaniciAdi.Text = "Lütfen Oyuncu İsmini Giriniz";
            }
        }
    }
}
