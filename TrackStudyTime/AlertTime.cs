using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackStudyTime
{
    class AlertTime
    {
        public static bool trentaMinutiObiettivo(int tempo, int obiettivo)
        {
            return (obiettivo - tempo == 1800) ? true : false;
        }
        public static bool obiettivoRaggiunto(int tempo, int obiettivo)
        {
            return (obiettivo - tempo == 0) ? true : false;
        }
        public static bool pausaExceed(int actualSec, int pausa)
        {
            return (actualSec - pausa == 0) ? true : false;
        }
    }
}
