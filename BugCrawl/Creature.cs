namespace BugCrawl
{
    public class Creature
    {
        public  string body { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public  string name { get; set; }

        public Creature(string name)
        {
            this.body = "X";
            this.Xpos = 0;
            this.Ypos = 0;
            this.name = name;
        }


        //think method

        //moverandom
    }
}