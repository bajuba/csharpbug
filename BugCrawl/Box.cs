using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BugCrawl
{
    public class Box : Creature
    {
        int directionX = 0;
        int directionY = 0;

        Random rand;
        

        public Box(string name):base(name)
        { 
            this.body = "^";    
        }

        public override void move()
        {   
            rand = new Random();
            int direction = rand.Next(2); 

            if(this.Xpos == 9) {directionX = -1; direction=2;} //rand.Next(-1, 1);    
            if(this.Xpos == 0) {directionX = 1; direction=2;} //rand.Next(2);
            if(this.Ypos == 9) {directionY = -1; direction=2;} //rand.Next(-1, 1);
            if(this.Ypos == 0) {directionY = 1; direction=2;} //rand.Next(2);                     

            else if(direction==0)
            {
                    directionX = rand.Next(-1, 2);
                    directionY = 0;
                    Console.WriteLine("X pos: " + this.Xpos + "\nY pos: " + this.Ypos);
                    Console.WriteLine("X axis " + directionX);
            }

            
            else if(direction==1)
            {                
                directionY = rand.Next(-1, 2);
                directionX = 0;
                Console.WriteLine("X pos: " + this.Xpos + "\nY pos: " + this.Ypos);
                Console.WriteLine("Y axis " + directionY);                
            }                   

            this.Ypos += directionX;
            this.Xpos += directionY;
            
        }
    }
}