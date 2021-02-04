using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrackStudyTime
{
    class StoreRetriveData
    {
        public static void setData(string nome, int obiettivo, int maxPausa, string password, string mail)
        {
            File.WriteAllText("settings.txt", nome + ";" + obiettivo + ";" + maxPausa+";"+password+";"+mail);
            
            
        }
        public static string[] getConfig()
        {
            try{
                string[] result = File.ReadAllLines("settings.txt");
                result = result[0].Split(';');
                return result;
            }
            catch
            {
                return null;
            }
            
        }
        /*
        public static void salvaTempo(string secondi, string minuti, string ore)
        {
            File.WriteAllText("time.txt", secondi + ";" + minuti + ";" + ore+";"+DateTime.Now.Day+DateTime.Now.Month);
        }
        public static string[] getTempoSeStessoGiorno()
        {
            try
            {
                string result = File.ReadAllText("time.txt");
                string[] stringa = result.Split(';');
                if (stringa[3].Equals(Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Month)))
                {
                    return stringa;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            
            
        }
        */
    }
}
