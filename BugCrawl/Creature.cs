using System;
namespace BugCrawl
{
    public class Creature
    {
        public  string body { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int xPos {get;set;}
        public int yPos {get;set;}
        public  string name { get; set; }
        public string dash {get;set;}

        public Creature(string name)
        {
            this.body = "X";
            this.dash = "-";
            this.Xpos = 0;
            this.Ypos = 0;
            this.name = name;
            this.xPos = 0;
            this.yPos = 0;

        }


        //think method
        public void think()
        {
            this.moveRandom();
        }
        //moverandom
        public void moveRandom()
        {
            this.xPos = this.Xpos;
            this.yPos = this.Ypos;

            Random rnd = new Random();
            this.Xpos = rnd.Next(0, 10);
            this.Ypos = rnd.Next(0, 10);

            

        }


    }
}