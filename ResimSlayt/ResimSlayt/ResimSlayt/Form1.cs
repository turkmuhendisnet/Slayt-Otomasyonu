using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimSlayt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image[] resimler = new Image[10];
        int RandomSayıKontrol = 0;
        int tiklama = 0;
        int sayac =0;

        private void btnStarStop_Click(object sender, EventArgs e)
        {
            tiklama++;              
            if (tiklama%2==1)
                tmrSure.Enabled = true;           
            else
                tmrSure.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resimler[0] = Properties.Resources.Resim1;
            resimler[1] = Properties.Resources.Resim2;
            resimler[2] = Properties.Resources.Resim3;
            resimler[3] = Properties.Resources.Resim4;
            resimler[4] = Properties.Resources.Resim5;
            resimler[5] = Properties.Resources.Resim6;
            resimler[6] = Properties.Resources.Resim7;
            resimler[7] = Properties.Resources.Resim8;
            resimler[8] = Properties.Resources.Resim9;
            resimler[9] = Properties.Resources.Resim10;
            

            tmrSure.Enabled = false;
            tmrSure.Interval = 3000;

        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            if (sayac>=9)
                sayac = 0;
            else
                sayac++;
            pctrBxResimler.Image = resimler[sayac];
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            pctrBxResimler.Image = resimler[9];
        }

        private void btnilk_Click(object sender, EventArgs e)
        {
            pctrBxResimler.Image = resimler[0];
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            if (sayac <=0)
                sayac = resimler.Length-1;
            else
               sayac--;
            pctrBxResimler.Image = resimler[sayac];
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            Random RastgeleSayi = new Random();
            sayac = RastgeleSayi.Next(0, resimler.Length);
            
            if (RandomSayıKontrol!=sayac)
            {
                pctrBxResimler.Image = resimler[sayac];
                RandomSayıKontrol = sayac;
            }
            else
            {
                RandomSayıKontrol++;
                pctrBxResimler.Image = resimler[sayac];

            }
        }
    }
}
