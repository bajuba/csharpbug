using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BugCrawl
{
    public class RBug : Creature
    {
        Random rnd = new Random();
        int xDirection;
        int yDirection;
        
        public RBug(string name):base(name)
        { 
            this.body = "r";
            
        }

        public override void move()
        {
            this.xDirection = rnd.Next(-1, 2);
            this.yDirection = rnd.Next(-1, 2);
            
            if(this.Xpos == 9){
                this.xDirection = -1;
                }
            if(this.Ypos == 9){
                this.yDirection = -1;
                }
            if(this.Xpos == 0){
                this.xDirection = 1;
                }
            if(this.Ypos == 0){
                this.yDirection = 1;
                }
            
            this.Xpos += this.xDirection;
            this.Ypos += this.yDirection;

        }

    }
}
