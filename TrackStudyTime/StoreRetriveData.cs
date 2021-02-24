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
        public static void settinggGrafico(string partenza, string finale)
        {
            File.WriteAllText("grafico.txt", partenza + ";" + finale);
        }
        public static DateTime[] getGrafico()
        {
            try
            {
                string[] res=File.ReadAllText("grafico.txt").Split(';');
                string[] iniziale = res[0].Split('-');
                string[] arrivo = res[1].Split('-');
                DateTime[] finale = new DateTime[2];
                finale[0] = new DateTime(Convert.ToInt32(iniziale[0]), Convert.ToInt32(iniziale[1]), Convert.ToInt32(iniziale[2]));
                finale[1] = new DateTime(Convert.ToInt32(arrivo[0]), Convert.ToInt32(arrivo[1]), Convert.ToInt32(arrivo[2]));
                return finale;
            }
            catch
            {
                return null;
            }
            
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
    }
}
