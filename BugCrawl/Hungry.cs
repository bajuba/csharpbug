using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BugCrawl
{
    public class Hungry : Creature
    {
        World myWorld;
        
        public Hungry(string name, World myWorld):base(name)
        { 
            this.body = "C";
            this.myWorld = myWorld;
            this.Xpos = 9;
            this.Ypos = 9;   
        }

        public override void move()
        {
            
            //detect nearest boring and move towards it
            Boring target = myWorld.stuff.OfType<Boring>().FirstOrDefault();
            
            if(this.Xpos < target.Xpos)
                this.Xpos += 1;
            else if(this.Xpos > target.Xpos)
                this.Xpos -= 1;
            else if(this.Ypos < target.Ypos)
                this.Ypos += 1;
            else if(this.Ypos > target.Ypos)
                this.Ypos -= 1;
            if(this.Ypos == target.Ypos && this.Xpos == target.Xpos)
            {
                //eat the Boring
                myWorld.stuff.Remove(target);
            }
        }

        
    }
}
