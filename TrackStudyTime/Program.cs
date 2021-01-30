using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackStudyTime
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
             * questo programma tiene il tempo del tuo studio
             * ti fa fissare un obbiettivo di ore al giorno
             * ti fa segnare le pause e nel caso siano troppo lunghe
             * ti avvisa con un segnale acustico
             * ti motiva nello studio
             * ti dice quando sei vicino all'obbiettivo di ore
             * feature futura: inclusive mode
             * inclusive mode ti permette per un certo tempo di usare 
             * solo le applicazioni permesse
             */
        }
    }
}
