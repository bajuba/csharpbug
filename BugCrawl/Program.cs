using System;
using System.Timers;
// https://stackoverflow.com/questions/9977393/how-do-i-pass-an-object-into-a-timer-event
namespace BugCrawl
{
    class Program
    {
        private static Timer aTimer;

        static void Main(string[] args)
        {
            World myWorld = new World("bob");

            Creature bug = new Creature("logan");
            Boring bug2 = new Boring("logan");
            Reptar bug7 = new Reptar("logan");
            myWorld.stuff.Add(bug);

            //Boring bug2 = new Boring("logan");
            myWorld.stuff.Add(bug2);
            myWorld.stuff.Add(bug7);

            //Hungry bug3 = new Hungry("race", myWorld);
            //myWorld.stuff.Add(bug3);

//instantiate and add an instance of your creature subclass to the stuff list in myWorld
            //Console.WriteLine(myWorld.draw());
            //Console.WriteLine(myWorld.sayName());
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000;

            // Hook up the Elapsed event for the timer. 
            // aTimer.Elapsed += render;
            aTimer.Elapsed += (sender, e) => render(sender, e, myWorld);

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
            Console.WriteLine("Press the Enter key to exit anytime... ");
            Console.ReadLine();
        }
        static void render(Object source, System.Timers.ElapsedEventArgs e, World myWorld)
        {
            Console.Clear();
            foreach(var guy in myWorld.stuff)
            {
                //guy.think();
                guy.move();
            }
             
            // Console.WriteLine("hello");
        Console.WriteLine("Raised: {0}", e.SignalTime);
        Console.WriteLine("Creature X: {0}", myWorld.stuff[0].Xpos);
        
        Console.WriteLine(myWorld.draw());
        
        }
    }
}
