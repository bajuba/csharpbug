using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BugCrawl
{
    public class World
    {
        //public List<List<string>> stage = new List<List<string>>();
        public List<string> groundLevel;
        public List<string> surfaceLevel;
        public List<string> skyLevel;
        public string name;
        public List<Creature> stuff;
        const int width = 10;

        public World(string inputName)
        {
            groundLevel = new List<string>();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    //this.stage[x+y*width] = "-";
                    this.groundLevel.Add("-");
                }
            }

            surfaceLevel = new List<string>();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    //this.stage[x+y*width] = "-";
                    this.surfaceLevel.Add("");
                }
            }

            skyLevel = new List<string>();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    //this.stage[x+y*width] = "-";
                    this.skyLevel.Add("");
                }
            }

            this.name = inputName;
            stuff = new List<Creature>();
        }

        public string draw()
        {
            string toDraw = "";
            
            for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < width; y++)
                    {
                        //this.stage[x+y*width] = "-";
                        this.surfaceLevel[x + y * width] = ("");
                    }
                }
            
            foreach (Creature guy in this.stuff)
            {
                //x+y*width
                //surfaceLevel[guy.xPos+guy.yPos*width] = guy.dash;
                //clear out the surface level
                
                //adds the creatures into the surface level
                surfaceLevel[guy.Xpos + guy.Ypos * width] = guy.body;
            }
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    if (skyLevel[x + y * width] == "")
                    {
                        if (surfaceLevel[x + y * width] == "")
                            toDraw += groundLevel[x + y * width];
                        else
                            toDraw += surfaceLevel[x + y * width];
                    }
                    else
                        toDraw += skyLevel[x + y * width];

                    //toDraw += groundLevel[x + y * width];
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
