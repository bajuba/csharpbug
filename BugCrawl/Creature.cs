using System;
namespace BugCrawl
{
    public class Creature
    {
        public  string body { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public  string name { get; set; }
        public string dash {get;set;}

        public Creature(string name)
        {
            this.body = "X";
            this.dash = "-";
            this.Xpos = 0;
            this.Ypos = 0;

            if (name == null)
            {
                this.name = "Logan";
            }
            else
            {
                this.name = name;
            }

        }


        //think method
        public void think()
        {
            this.moveRandom();
        }
        //moverandom
        public void moveRandom()
        {
            
            

            

        }
        virtual public void move()
        {
            Random rnd = new Random();
            this.Xpos = rnd.Next(0, 10);
            this.Ypos = rnd.Next(0, 10);
        }

    }
}