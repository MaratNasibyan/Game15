using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.Services
{
    public class TimerService
    {
        Stopwatch timer = new Stopwatch();

        public TimerService()
        {
            //      timer.Start();

            ////B: Run stuff you want timed
            //timer.Stop();

            //TimeSpan timeTaken = timer.Elapsed;
            //      string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
