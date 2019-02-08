using System;
using System.Collections.Generic;

namespace StopWatchTutorial
{

    class Program
    {
        static void Main()
        {
            var stopWatch = new StopWatch();

            string value = "";

            Console.WriteLine("Type start, stop or end");

            while (value != "end"){

            value = Console.ReadLine();

            if (value == "start")
            {
                stopWatch.Start();
            }
            else if (value == "stop")
            {
                stopWatch.Stop();
            }

            }



        }
    }
    
} 
