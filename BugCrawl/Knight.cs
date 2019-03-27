using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BugCrawl
{
	public class Knight : Creature
	{
		public Knight(string name) : base(name)
        { 
            this.body = "K";    
        }

	    public static int RandomNumber(int min, int max)
		{
			//this generates a random number between to 2 numbers passed into this method (min is included as a possiblity)
			Random random = new Random();  
    	    return random.Next(min, max); 
		}

		public void MoveLogic(ref int x, ref int y, int moveX, int moveY, int direction)
		{
			if(moveX == 1)
			{
				//a knight can move 2 squares up or down and 1 right or left or vice versa
				//if it movers 1 right or left it must move 2 up or down
				moveY = 2;
			}
			else
			{
				//a knight can move 2 squares up or down and 1 right or left or vice versa
				//if it movers 2 right or left it must move 1 up or down
				moveY = 1;
			}

			//in chess a knight has 8 possible directions it could move but we only need to check 4 possiblities
			//this because a knight has 4 possible move options if it were to move up(or down) 1 on its y axis and 2 arross right(or left)
			//we cut 8 down to 4 by determining how much it will move on its x and y axis in the if block above 
			if(direction == 1)
			{
				x += moveX;
				y += moveY;
			}
			else if(direction == 2)
			{
				x += moveX;
				y -= moveY;
			}
			else if(direction == 3)
			{
				x -= moveX;
				y += moveY;
			}
			else
			{
				x -= moveX;
				y -= moveY;
			}
		}

		public override void move()
		{
			int xPos = this.Xpos; //gets the current x position
			int yPos = this.Ypos; //gets the current y position
			int xPosCopy = xPos; //makes a copy of xPos for testing purposes
			int yPosCopy = yPos; //makes a copy of yPos fot testing purposes
			bool moveFound = false; //this will be used to determine if a valid move has been found
			int moveX = RandomNumber(1, 3); //a knight can move 2 and then 1 space or vice versa this generates either a 1 or a 2
			int moveY = 0; //the value of moveY is dependent of what moveX is. If moveX is 1 then moveY must be 2 and vice versa
			int direction = RandomNumber(1, 5); //there are 4 directions possible for the knight to follow this will determine one randomly

			//this sends the cody variables through the method first along with the chosen move options
			MoveLogic(ref xPosCopy, ref yPosCopy, moveX, moveY, direction);

			//this will continue to loop until a valid move is chosen.
			//an invalid move would place the knight off of the world
			while(moveFound == false)
			{
				//this checks to see if the new position with the copy variables is within the world
				if((xPosCopy <= 9 && xPosCopy >= 0) && (yPosCopy <= 9 && yPosCopy >= 0))
				{
					//if it is, now we pass in the original x and y variables (xPos and yPos) along with the varified move patterns
					MoveLogic(ref xPos, ref yPos, moveX, moveY, direction);
					//with a valid move found we can end the loop
					moveFound = true;
				}
				//if the new position would put the knight off the world we must run the code again with new patterns
				else
				{
					xPosCopy = xPos; //this resets the copy of x to the starting value of the original x position
					yPosCopy = yPos; //this resets the copy of y to the starting value of the original y position
					moveX = RandomNumber(1, 3); //determine a new number to increment on the x axil
					moveY = 0; //y must be reset 
					direction = RandomNumber(1, 5); //a new direction must be determined

					//pass the copies through again with the new moveX, moveY and dexision
					MoveLogic(ref xPosCopy, ref yPosCopy, moveX, moveY, direction);
				}
			}

			this.Xpos = xPos; //once the loop is broken move the knight to its new x possision
			this.Ypos = yPos; //once the loop is broken move the knight to its new y possision
		}
	}
}