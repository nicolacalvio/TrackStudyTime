using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackStudyTime
{
    class DateUtil
    {
        public static string convertiInFormatoIta(string data)
        {
            //da 2021-02-10 a 10/02/2021
            string[] res = data.Split('-');
            string fin = res[2] + "/" + res[1] + "/" + res[0];
            return fin;
        }
    }
}
