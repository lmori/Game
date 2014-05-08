using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Theseus_vs_Minotaur_library
{
  public class Character
    {
        private int xPosition, yPosition;
        private GameController myGameController;
        private string spritePath;// image/skin?

        public string SpritePath
        {
            get { return spritePath; }
            set { spritePath = value; }
        }

        public GameController MyGameController
        {
            get { return myGameController; }
            set { myGameController = value; }
        }
        // Level myLevel; Possible implementation??
        

        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }

        public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }

        public Character(GameController theGameController) 
        { 
           this.myGameController = theGameController;
           SpritePath = System.IO.Directory.GetCurrentDirectory();
           SpritePath += "\\images";
        }

    }

   public class Theseus : Character
    {
       public Theseus(GameController theGameController)
           : base(theGameController)
        {
           SpritePath += "\\theseus.png";
        }

        public bool Move (Direction direction)
        {
            // define variables
            int newX = 0;
            int newY = 0;

            // Find the target tile based on the inputted direction
                switch (direction)
                {
                    case Direction.Right:
                        newX = this.XPosition + 1;
                        newY = this.YPosition;
                        break;
                    case Direction.Left:
                        newX = this.XPosition - 1;
                        newY = this.YPosition;
                        break;
                    case Direction.Up:
                        newY = this.YPosition - 1;
                        newX = this.XPosition;
                        break;
                    case Direction.Down:
                        newY = this.YPosition + 1;
                        newX = this.XPosition;
                        break;
                    case Direction.NoChange:
                        newY = this.YPosition;
                        newX = this.XPosition;
                        break;
                }
                Console.WriteLine(MyGameController.CurrentLevel.IsWall(this.XPosition, this.YPosition, direction).ToString());
            // if there is no wall between theseus and the target tile
            if (!MyGameController.CurrentLevel.IsWall(this.XPosition, this.YPosition, direction))  //Possible implementation??
            {
                // Record the move in the controller list
                MyGameController.LogMove(direction);

                // set theseus's new position to the target position
                this.XPosition = newX;
                this.YPosition = newY;

                // and return true
                return true;
            }
            else
            {
                // errors go here
                return false;
            }

            
        }
    }

    public class Minotaur : Character
    {
        public Minotaur(GameController theGameController)
            : base(theGameController)
        {
            SpritePath += "\\minotaur.png";
        }
       
        public int[][] Move () // The Minotaur always moves twice so method returns an array with two sets of xy ints
        {
            // define variables
            int[][] minotaurMoves = new int[2][];
            minotaurMoves[0] = new int[2];            
            minotaurMoves[1] = new int[2];
            int moveCount = 0;
            int theseusX, theseusY, newX, newY;
            Direction horizontalMove = Direction.NoChange;
            Direction verticalMove = Direction.NoChange;
            
            // Find out where Theseus is
            theseusX = MyGameController.MyTheseus.XPosition;
            theseusY = MyGameController.MyTheseus.YPosition;

            

            // two moves
            while (moveCount < 2)
            {
                // Compare horozontial locations to get to Theseus

                // if Theseus is to the left of the Minotaur
                if (theseusX < this.XPosition)
                {
                    // Subtract 1 from Minotaur X to move left
                    horizontalMove = Direction.Left;
                    
                    if (MyGameController.CurrentLevel.IsWall(this.XPosition, this.YPosition, horizontalMove) == false)
                    {
                        newX = this.XPosition - 1;
                    }
                    else
                    {
                        newX = this.XPosition;
                    }


                }
                // if Theseus is to the right of the Minotaur
                else if (this.XPosition < theseusX)
                {
                    // Add 1 to Minotaur X to move right
                    horizontalMove = Direction.Right;
                    if (MyGameController.CurrentLevel.IsWall(this.XPosition, this.YPosition, horizontalMove) == false)
                    {
                        newX = this.XPosition + 1;
                    }
                    else
                    {
                        newX = this.XPosition;
                    }


                }
                // Otherwise if the horizontal values match
                else
                {
                    // In case a Y move can be made
                    horizontalMove = Direction.NoChange;
                    newX = this.XPosition;
                }
                

                // Check the horizontal move is valid (no walls/out of bounds/etc)
                //if (horizontalMove != Direction.NoChange && !MyGameController.CurrentLevel.IsWall(this.YPosition, newX, horizontalMove))
                /*  if ( !MyGameController.CurrentLevel.IsWall(newX, this.YPosition, horizontalMove))
                  {
                      
                  }*/
                minotaurMoves[0][0] = newX;
                minotaurMoves[0][1] = this.YPosition;
                moveCount++;

                // Compare vertical locations to get to Theseus

                // if theseus is above the minotaur
                if (theseusY < this.YPosition)
                {
                    // Subtract 1 from Minotaur Y to move up
                    verticalMove = Direction.Up;
                    if (MyGameController.CurrentLevel.IsWall(this.XPosition, this.YPosition, verticalMove) == false)
                    {
                        
                        newY = this.YPosition - 1;
                    }
                    else
                    {
                        newY = this.YPosition;
                    }
                    
                    
                }


                // if Theseus is below the Minotaur
                else if (this.YPosition < theseusY)
                {
                    // Add 1 to Minotaur Y to move down
                    verticalMove = Direction.Down;

                    if (MyGameController.CurrentLevel.IsWall(this.XPosition, this.YPosition, verticalMove) == false)
                    {
                        

                        newY = this.YPosition + 1;
                    }
                    else
                    {
                        newY = this.YPosition;
                    }
                }


                else
                {
                    // In case an X move can be made
                    verticalMove = Direction.NoChange;
                    newY = this.YPosition;

                }

                // Check the vertical move is valid (no walls/out of bounds/etc)
               // if (!MyGameController.CurrentLevel.IsWall(newY, newX, horizontalMove))

                    minotaurMoves[1][0] = newX;
                    minotaurMoves[1][1] = newY;
                    moveCount++;
             
            }
            return minotaurMoves;
        }
    }
}