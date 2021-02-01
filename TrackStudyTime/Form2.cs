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
    public partial class Form2 : Form
    {
        public string nomeUtente;
        public Form2(string nomeUtente)
        {
            InitializeComponent();
            this.nomeUtente = nomeUtente;
        }
        private void refreshFirends()
        {
            Dictionary<string, int> d = ConnectionUtil.prendiTempoAmici(nomeUtente);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //TODO: caricare tutti i tempi degli amici
            refreshFirends();
        }

        private void aggAmico_Click(object sender, EventArgs e)
        {
            //TODO: aggiungere gli amici
            if (ConnectionUtil.utenteRegistrato(textBox1.Text))
            {
                ConnectionUtil.aggiungiAmico(nomeUtente, textBox1.Text);
                MessageBox.Show("amico aggiunto"); ;
            }
            else
            {
                MessageBox.Show("l'username cercato non è presente");
            }
            refreshFirends();
        }
    }
}
