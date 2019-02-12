using System;
using System.Timers;

namespace BugCrawl
{
    class Program
    {
        //declare aTimer form system
        private static System.Timers.Timer aTimer = new System.Timers.Timer();
        private static void Main(string[] args)
        {             
            World myWorld = new World("bob");


            //create function to pull the world into the render timer
            Object createWorld()
            {
                return myWorld.draw();
            }           

            //create render function to process info from event handler below
            void render(Object source, System.Timers.ElapsedEventArgs e)
            {
                //erase the world
                //Console.Clear();
                //recreate the world
                Console.WriteLine(createWorld());
            }

                //timer interval is set to 1 second      
                aTimer.Interval = 50;
                //event handler sends timer info to render()
                aTimer.Elapsed += new ElapsedEventHandler(render);
                //autoreset timer after interval      
                aTimer.AutoReset = true;
                //timer is enabled
                aTimer.Enabled = true;           
            

            //the world will regenerate until the combination is pressed
            Console.WriteLine("Press 'q' then 'enter' to quit");            
            while(Console.Read()!='q');           
        }
    }    
}
