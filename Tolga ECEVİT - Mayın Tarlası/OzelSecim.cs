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
    public partial class OzelSecim : Form
    {
        public OzelSecim()
        {
            InitializeComponent();
        }

        public Form2 gelenEkran = new Form2();
        public int ozelYukseklik;
        public int ozelGenislik;
        public int ozelMayinSayisi;
        DialogResult dr = new DialogResult();

        private void btnOyunOlustur_Click(object sender, EventArgs e)
        {
            ozelYukseklik = (int)numYukseklik.Value;
            ozelGenislik = (int)numGenislik.Value;
            ozelMayinSayisi = (int)numMayinSayisi.Value;

            dr = DialogResult.OK;

            if (dr==DialogResult.OK)
            {
                gelenEkran.MayinOlustur(ozelMayinSayisi, ozelYukseklik, ozelGenislik);
                gelenEkran.LabelGoster();
                gelenEkran.OyuncuAdiGoster();
                gelenEkran.timer1.Start();
                gelenEkran.lblSkor2.Visible = true;
                gelenEkran.kalanSure = 30;
                gelenEkran.oyuncuSkoru = 0;
                this.Close();

            }
        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
