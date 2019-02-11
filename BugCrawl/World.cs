using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BugCrawl
{
    public class World
    {
        public List<List<string>> stage = new List<List<string>>();
        public string name="";

        public World(string inputName){
            stage = new List<List<string>>();
            for(int i=0;i<10;i++)
            {
                this.stage.Add(new List<string>());
               for(int j=0;j<10;j++)
               {
                   this.stage[i].Add("-");
               }
            }
            this.name = inputName;
        }
        public string draw(){
            string toDraw="";
            for(int i=0;i<10;i++)
            {
               for(int j=0;j<10;j++)
               {
                   toDraw+=stage[i][j];
                   //toDraw= toDraw + stage[i][j];
               }
               toDraw += "\n";
            }
            return toDraw;
        }
        public string sayName()
        {
            return this.name;
        }
    }
}
