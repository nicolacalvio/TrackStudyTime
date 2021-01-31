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
        public static void setData(string nome, int obiettivo, int maxPausa)
        {
            File.WriteAllText("settings.txt", nome + ";" + obiettivo + ";" + maxPausa);
            
            
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
