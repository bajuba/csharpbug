using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BugCrawl
{
    public class Reptar : Creature
    {
        public Reptar(string name):base(name)
        { 
            this.body = "R";    
        }
        

        public override void move()
        {
            if (this.Xpos == 0 && this.Ypos == 0) 
            {
                Random rnd = new Random();
                this.Xpos = rnd.Next(0, 10);
                this.Ypos = rnd.Next(0, 10);
            }

            this.Ypos --;
            if (this.Ypos == -1)
            {
                this.Ypos = 9;
                this.Xpos --;
            }

            
        }

    }
}
