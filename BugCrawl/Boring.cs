using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BugCrawl
{
    public class Boring : Creature
    {
        int direction = 1;
        public Boring(string name):base(name)
        { 
            this.body = "D";    
        }

        public override void move()
        {
            
            
            if(this.Xpos == 9)
                direction = -1;
            if(this.Xpos == 0)
                direction = 1;

            this.Xpos += direction;
            this.Ypos += direction;
            
        }

    }
}
