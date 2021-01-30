using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackStudyTime
{
    class TimeUtil
    {
        public int timeStart = 0, timeFinish = 0;
        public int timeStartP = 0, timeFinishP = 0;


        public string calcolaDiffTime()
        {
            TimeSpan t = TimeSpan.FromSeconds(timeFinish-timeStart);

            return string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                            t.Hours,
                            t.Minutes,
                            t.Seconds,
                            t.Milliseconds);
        }

        public string calcolaDiffTimePausa()
        {
            TimeSpan t = TimeSpan.FromSeconds(timeFinishP - timeStartP);

            return string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                            t.Hours,
                            t.Minutes,
                            t.Seconds,
                            t.Milliseconds);
        }

    }
}
