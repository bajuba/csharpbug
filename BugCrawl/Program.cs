using System;
using System.Timers;

namespace BugCrawl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        var aTimer = new Timer();
        aTimer.Interval = 50;

        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += render;

        // Have the timer fire repeated events (true is the default)
        aTimer.AutoReset = true;

        // Start the timer
        aTimer.Enabled = true;

       
        }
        private static void render(Object source, System.Timers.ElapsedEventArgs e)
        {
            //Console.Clear();
            Console.WriteLine("hello");
        }
    }
}
