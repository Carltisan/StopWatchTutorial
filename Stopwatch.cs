using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchTutorial
{
    public class StopWatch
    {

        public DateTime? StartTime { get; set; }

        public TimeSpan? EndTime
        {
            get
            {
                
                var timeSpan = DateTime.Now - StartTime;

                return timeSpan;
            }
        }

        public void Start()
        {
            if (!StartTime.HasValue)
            {
                StartTime = DateTime.Now;
                Console.WriteLine("Stop Watch Started");
            }
            else
            {
                throw new InvalidOperationException("Watch already started");
            }


           
        }

        public void Stop()
        {
            if (StartTime.HasValue)
            {
                Console.WriteLine(EndTime);
                StartTime = null;
            }
            else
            {
                throw new InvalidOperationException("Please start Watch first");
            }
            
        }
       
    }
}
