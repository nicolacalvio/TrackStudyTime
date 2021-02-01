﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackStudyTime
{
    public partial class Form1 : Form
    {
        string nomeUtente;
        string passwordStore;
        int pausaCont = 0;
        bool pastoP = false;
        int obiettivoOre, massimaPausa;
        bool configurazione = false;
        int secondiPassati = 0, minutiPassati = 0, orePassate = 0;
        int actualSecs = 0;
        int actualSecsZero = 0;
        int countPause = 0, countStudio = 0;
        int totalePausa = 0;
        TimeUtil timeUtil = new TimeUtil();
        //TODO: aggiungere webserver che traccia il tempo degli amici
        //per stilare una classifica
        //gli amici si possono aggiungere tramite username
        //TODO: aggiungere sistema di reward in base a quante volte si raggiunge un obiettivo
        //e a quante volte si battono gli amici
        //TODO: aggiungere dialog per la conferma della chiusura dell'applicazione
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
                timeUtil.timeStart = secondiPassati + (minutiPassati * 60) + ((orePassate * 60) * 60);
                timeUtil.timeFinishP = actualSecs;
                timer2.Stop();
                if (!pastoP)
                {

                    if (countPause != 0)
                    {
                        listBox1.Items.Add("#" + Convert.ToString(countPause) + " " + timeUtil.calcolaDiffTimePausa());
                    }
                    countPause++;
                    actualSecsZero = 0;
                }
                else
                {
                    
                    pastoP = false;
                }
                play.Enabled = false;
                pause.Enabled = true;
                pasto.Enabled = true;

            }
            else
            {
                MessageBox.Show("Non hai completato la configurazione perfavore riempi tuti i campi e premi salva");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            actualSecs++;
            actualSecsZero++;
            pausaCont++;
            durataTotaleP.Text = TimeUtil.convertSecToTime(pausaCont);
            if (AlertTime.pausaExceed(actualSecsZero, massimaPausa*60))
            {
                SoundPlayer simpleSound = new SoundPlayer("pausa_superata.wav");
                simpleSound.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] result = StoreRetriveData.getConfig();
            if (result != null)
            {
                nomeUtente = result[0];
                obiettivoOre = Convert.ToInt32(result[1]);
                massimaPausa = Convert.ToInt32(result[2]);
                passwordStore = result[3];
                nome.Text = nomeUtente;
                obiettivo.Value = obiettivoOre;
                pausa.Value = massimaPausa;
                password.Text = passwordStore;
                configurazione = true;
            }
            string[] tempoSaved = StoreRetriveData.getTempoSeStessoGiorno();
            if (tempoSaved != null)
            {
                secondiPassati = Convert.ToInt32(tempoSaved[0]);
                minutiPassati = Convert.ToInt32(tempoSaved[1]);
                orePassate = Convert.ToInt32(tempoSaved[2]);
                secondi.Text = (secondiPassati < 10) ? "0" + tempoSaved[0] : tempoSaved[0];
                minuti.Text = (minutiPassati < 10) ? "0" + tempoSaved[1] : tempoSaved[1];
                ore.Text = (orePassate < 10) ? "0" + tempoSaved[2] : tempoSaved[2];
            }


        }

        private void pasto_Click(object sender, EventArgs e)
        {
            pause.Enabled = false;
            pasto.Enabled = false;
            play.Enabled = true;
            timer1.Stop();
            timer2.Stop();
            timeUtil.timeFinish = secondiPassati + (minutiPassati * 60) + ((orePassate * 60) * 60);
            countStudio++;
            listBox2.Items.Add("#" + Convert.ToString(countStudio) + " " + timeUtil.calcolaDiffTime());
            actualSecs = timeUtil.timeFinish;
            pastoP = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nicolacalvio.com");
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeUtil.timeFinish = secondiPassati + (minutiPassati * 60) + ((orePassate * 60) * 60);
            countStudio++;
            listBox2.Items.Add("#" + Convert.ToString(countStudio) + " " + timeUtil.calcolaDiffTime());
            actualSecs = timeUtil.timeFinish;
            timeUtil.timeStartP = timeUtil.timeFinish;
            timer2.Enabled = true;
            timer2.Start();
            pause.Enabled = false;
            pasto.Enabled = false;
            play.Enabled = true;
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            StoreRetriveData.salvaTempo(Convert.ToString(secondiPassati), Convert.ToString(minutiPassati), Convert.ToString(orePassate));
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
                minuti.Text = "0" + Convert.ToString(minutiPassati);
            }
            else
            {
                minuti.Text = Convert.ToString(minutiPassati);
            }
            ConnectionUtil.mandaTempo(nomeUtente, secondiPassati + (minutiPassati * 60) + (minutiPassati * 60) * 60);

        }


        void aggiungiOra()
        {
            orePassate++;
            ore.Text = "0" + Convert.ToString(orePassate);
        }

        private void timePausebtn_Click(object sender, EventArgs e)
        {
            if (durataTotaleP.Visible)
            {
                durataTotaleP.Visible = false;
            }
            else
            {
                durataTotaleP.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salva();
            //chiama connection util per mandare username e password
            //che nel caso già esistenti nel server
            //il server farà login altrimenti creerà un nuovo utente
            if(!ConnectionUtil.utenteRegistrato(nomeUtente))
            {
                ConnectionUtil.registraUtente(nomeUtente, passwordStore);
            }

        }

        private void Amici_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(nomeUtente);
            f.Show();
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
                secondi.Text = "0" + Convert.ToString(secondiPassati);
            }
            else
            {
                secondi.Text = Convert.ToString(secondiPassati);
            }
            if(AlertTime.trentaMinutiObiettivo(secondiPassati + (minutiPassati * 60) + (orePassate * 60) * 60, (obiettivoOre * 60) * 60))
            {
                SoundPlayer simpleSound = new SoundPlayer("30min.wav");
                simpleSound.Play();
            }
            if (AlertTime.obiettivoRaggiunto(secondiPassati + (minutiPassati * 60) + (orePassate * 60) * 60, (obiettivoOre * 60) * 60))
            {
                SoundPlayer simpleSound = new SoundPlayer("obiettivo_raggiunto.wav");
                simpleSound.Play();
            }
            //ConnectionUtil.mandaTempo(nomeUtente, secondiPassati + (minutiPassati * 60) + (minutiPassati * 60) * 60);


        }
        private void salva()
        {
            nomeUtente = nome.Text;
            obiettivoOre = Convert.ToInt32(obiettivo.Value);
            massimaPausa = Convert.ToInt32(pausa.Value);
            passwordStore = password.Text;
            if (!nomeUtente.Equals("") && obiettivoOre != 0 && massimaPausa != 0)
            {
                configurazione = true;
                StoreRetriveData.setData(nomeUtente, obiettivoOre, massimaPausa, passwordStore);
            }
            else
            {
                MessageBox.Show("non hai riempito i campi richiesti. Compilali e riprova");
            }
        }
        private void salva_Click(object sender, EventArgs e)
        {
            salva();
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            salva();
        }
    }
}
