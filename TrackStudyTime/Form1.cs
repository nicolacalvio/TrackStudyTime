using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackStudyTime
{
    public partial class Form1 : Form
    {
        string nomeUtente;
        int obiettivoOre, massimaPausa;
        bool configurazione = false;
        int secondiPassati = 0, minutiPassati = 0, orePassate=0;
        int actualSecs = 0;
        int countPause = 0, countStudio=0;
        TimeUtil timeUtil = new TimeUtil();
        int tick1 = 0, tick2 = 0;

        //bug: quando il cronometro sta andando non posso schiacciare play
        //TODO: aggiungere tasto pausa pranzo/cena
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            if (configurazione)
            {
                timer1.Enabled = true;
                timer1.Start();
                timeUtil.timeStart = secondiPassati + (minutiPassati / 60) + ((orePassate / 60) / 60);
                timeUtil.timeFinishP = actualSecs;
                timer2.Stop();
                if (countPause != 0)
                {
                    listBox1.Items.Add("#" + Convert.ToString(countPause) + " " + timeUtil.calcolaDiffTimePausa());
                }
                countPause++;
                play.Enabled = false;
                pause.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Non hai completato la configurazione perfavore riempi tuti i campi e premi salva");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            actualSecs++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pasto_Click(object sender, EventArgs e)
        {
            play.Enabled = true;
            pause.Enabled = false;
            timer1.Stop();
            timer2.Stop();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeUtil.timeFinish = secondiPassati + (minutiPassati / 60) + ((orePassate / 60) / 60);
            countStudio++;
            listBox2.Items.Add("#"+Convert.ToString(countStudio) + " " + timeUtil.calcolaDiffTime());
            actualSecs = timeUtil.timeFinish;
            timeUtil.timeStartP = timeUtil.timeFinish;
            timer2.Enabled = true;
            timer2.Start();
            pause.Enabled = false;
            play.Enabled = true;
        }
        void aggiungiMinuto()
        {
            if (minutiPassati == 60)
            {
                minutiPassati = 0;
                aggiungiOra();
            }
            else
            {
                minutiPassati++;
            }
            if (minutiPassati < 10)
            {
                minuti.Text = "0"+Convert.ToString(minutiPassati);
            }
            else
            {
                minuti.Text = Convert.ToString(minutiPassati);
            }

        }

        void aggiungiOra()
        {
            orePassate++;
            ore.Text = "0"+Convert.ToString(orePassate);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (secondiPassati == 60)
            {
                secondiPassati = 0;
                aggiungiMinuto();
            }
            else
            {
                secondiPassati++;
            }
            if (secondiPassati < 10)
            {
                secondi.Text = "0"+Convert.ToString(secondiPassati);
            }
            else
            {
                secondi.Text = Convert.ToString(secondiPassati);
            }
            
            
        }

        private void salva_Click(object sender, EventArgs e)
        {
            nomeUtente = nome.Text;
            obiettivoOre = Convert.ToInt32(obiettivo.Value);
            massimaPausa = Convert.ToInt32(pausa.Value);
            if(!nomeUtente.Equals("") && obiettivoOre!=0 && massimaPausa != 0)
            {
                configurazione = true;
                //TO-DO: scrivere su file i dati della configurazione
            }
            else
            {
                MessageBox.Show("non hai riempito i campi richiesti. Compilali e riprova");
            }
        }
    }
}
