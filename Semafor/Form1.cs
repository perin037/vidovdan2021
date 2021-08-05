using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Form1 : Form
    {
        int tSec, tMin;
        String domacinIme, gostIme;
        bool aktivna;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            aktivna = true;
        }

        private void btnPauza_Click(object sender, EventArgs e)
        {
            aktivna = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            aktivna = false;
            ResetujVreme();
            IspisiVreme();
            //ResetujEkipe();
            //IspisiEkipe();
        }
        public void ResetujVreme()
        {
            tSec = 0;
            //tMin = 12;
            tMin = 20;
            /*FormPodesiVreme podesiVreme = new FormPodesiVreme();
            podesiVreme.DataSent += podesiVreme_DataSent;
            podesiVreme.ShowDialog();*/
        }
        public void ResetujEkipe()
        {
            FormPodesiImena podesiImena = new FormPodesiImena();
            podesiImena.DataSent += podesiImena_DataSent;
            podesiImena.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aktivna){
                if (tSec == 1 && tMin == 0)
                {
                    //SoundPlayer player = new SoundPlayer("sirena.wav");
                    SoundPlayer player = new SoundPlayer("sirenanova.wav");
                    player.Play();
                }
                if (tSec == 0 && tMin == 0){
                    aktivna = false;
                    //SystemSounds.Beep.Play();
                    return;
                }
                if (tMin >= 0 && tSec >= 0){
                    if (tSec < 1){
                        tSec = 59;
                        tMin--;
                    }else{
                        tSec--;
                    }
                }


                //tSec++;
                /*if(tSec >= 60){
                    tSec = 0;
                    tMin++;
                }*/

                IspisiVreme();
            }
            /*if (aktivna){
                if(tSec < 1){
                    tSec = 59;
                    tMin--;
                }else{
                    tSec--;
                }
                tSec--;
            }*/
        }

        private void IspisiVreme()
        {
            lbMin.Text = String.Format("{0:00}", tMin);
            lbSec.Text = String.Format("{0:00}", tSec);
        }
        /*private void IspisiEkipe()
        {
            labelDomacin.Text = "Domacin";
            labelGost.Text = "Gost";
        }*/

        

        private void btnPodesiImena_Click(object sender, EventArgs e)
        {
            FormPodesiImena podesiImena = new FormPodesiImena();

            podesiImena.DataSent += podesiImena_DataSent;

            podesiImena.ShowDialog();
        }

        /*private void btnPodesiVreme_Click(object sender, EventArgs e)
        {
            FormPodesiVreme podesiVreme = new FormPodesiVreme();

            podesiVreme.DataSent += podesiVreme_DataSent;

            podesiVreme.ShowDialog();
        }*/

        private void podesiImena_DataSent(string domacin, string gost)
        {
            this.labelDomacin.Text = domacin;
            domacinIme = domacin;

            this.labelGost.Text = gost;
            gostIme = gost;

            //IspisiEkipe();
        }

        /*private void podesiVreme_DataSent(string minuti, string sekunde)
        {
            this.labelDomacin.Text = minuti;
            tMin = Convert.ToInt32(minuti);

            this.labelGost.Text = sekunde;
            tSec = Convert.ToInt32(sekunde);

            IspisiVreme();

        }*/

        private void btnDomaci_Click(object sender, EventArgs e)
        {
            int goloviDomacina = Convert.ToInt32(goloviDomacin.Text.ToString());
            goloviDomacina++;
            goloviDomacin.Text = goloviDomacina.ToString();
        }

        private void goloviDomacin_Click(object sender, EventArgs e)
        {
            int goloviDomacina = Convert.ToInt32(goloviDomacin.Text.ToString());
            goloviDomacina++;
            goloviDomacin.Text = goloviDomacina.ToString();
        }

        private void btnGosti_Click(object sender, EventArgs e)
        {
            int goloviGosta = Convert.ToInt32(goloviGost.Text.ToString());
            goloviGosta++;
            goloviGost.Text = goloviGosta.ToString();
        }

        private void goloviGost_Click(object sender, EventArgs e)
        {
            int goloviGosta = Convert.ToInt32(goloviGost.Text.ToString());
            goloviGosta++;
            goloviGost.Text = goloviGosta.ToString();
        }

        private void btnDomaciMinus_Click(object sender, EventArgs e)
        {
            int goloviDomacina = Convert.ToInt32(goloviDomacin.Text.ToString());
            goloviDomacina--;
            goloviDomacin.Text = goloviDomacina.ToString();
        }

        private void btnGostaMinus_Click(object sender, EventArgs e)
        {
            int goloviGosta = Convert.ToInt32(goloviGost.Text.ToString());
            goloviGosta--;
            goloviGost.Text = goloviGosta.ToString();
        }

        private void btnDodajDomacinuFaul_Click(object sender, EventArgs e)
        {
            int fauloviDomacina = Convert.ToInt32(fauloviDomacin.Text.ToString());
            fauloviDomacina++;
            fauloviDomacin.Text = fauloviDomacina.ToString();
        }

        private void btnOduzmiDomacinuFaul_Click(object sender, EventArgs e)
        {
            int fauloviDomacina = Convert.ToInt32(fauloviDomacin.Text.ToString());
            fauloviDomacina--;
            fauloviDomacin.Text = fauloviDomacina.ToString();
        }

        private void btnDodajGostuFaul_Click(object sender, EventArgs e)
        {
            int fauloviGosta = Convert.ToInt32(fauloviGost.Text.ToString());
            fauloviGosta++;
            fauloviGost.Text = fauloviGosta.ToString();
        }

        private void btnSledeciPeriod_Click(object sender, EventArgs e)
        {
            int pe = Convert.ToInt32(period.Text.ToString());
            pe++;
            period.Text = pe.ToString();
        }

        private void btnVratiPeriod_Click(object sender, EventArgs e)
        {
            int pe = Convert.ToInt32(period.Text.ToString());
            pe--;
            period.Text = pe.ToString();
        }

        private void btnOduzmiGostuFaul_Click(object sender, EventArgs e)
        {
            int fauloviGosta = Convert.ToInt32(fauloviGost.Text.ToString());
            fauloviGosta--;
            fauloviGost.Text = fauloviGosta.ToString();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetujVreme();
            IspisiVreme();
            ResetujEkipe();
            //IspisiEkipe();
            aktivna = false;
        }
    }
}
