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
        String nomeUtente;
        int obiettivoOre, massimaPausa;
        bool configurazione = false;
        int secondiPassati = 0, minutiPassati = 0, orePassate=0;
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
            }
            else
            {
                MessageBox.Show("Non hai completato la configurazione perfavore riempi tuti i campi e premi salva");
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listBox1.Items.Add("Tempo di studio:" + Convert.ToString(""));
            //TO-DO: implementare altro timer che calcola la pausa
            //TO-DO: aggiornare listbox
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
            ore.Text = Convert.ToString(orePassate);
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
                //TO-DO: scrivere su file i dati
            }
            else
            {
                MessageBox.Show("non hai riempito i campi richiesti. Compilali e riprova");
            }
        }
    }
}
