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
       
        private string spritePath;// image/skin?

        public string SpritePath
        {
            get { return spritePath; }
            set { spritePath = value; }
        }

     
        

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

        public Character() 
        { 
          SpritePath = System.IO.Directory.GetCurrentDirectory();
          SpritePath += "\\images";
        }

    }

   public class Theseus : Character
    {
       public Theseus()
           : base()
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

            // if there is no wall between theseus and the target tile
            if (!GameController.CurrentLevel.IsWall(this.XPosition, this.YPosition, direction))  //Possible implementation??
            {
                // Record the move in the controller list
                GameController.LogMove(direction);

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
        public Minotaur()
            : base()
        {
            SpritePath += "\\minotaur.png";
        }


        // MAKE THE FIRST MOVE
        public int[][] CompleteMove()
        {
            // Define variables
            int[][] minotaurMoves = new int[2][];
            minotaurMoves[0] = new int[2];
            minotaurMoves[1] = new int[2];
            int theseusX, theseusY;
            int minotaurX, minotaurY, newMinotaurX, newMinotaurY;

            bool moveFailed = false;
            int currentMove = 0;

            // Find out where Theseus is
            theseusX = GameController.MyTheseus.XPosition;
            theseusY = GameController.MyTheseus.YPosition;

            // Find out where Minotaur is.
            minotaurX = GameController.MyMinotaur.XPosition;
            minotaurY = GameController.MyMinotaur.YPosition;




            // Compare horozontial locations to get to Theseus

            // If Theseus is to the left of the Minotaur.
            if (theseusX < minotaurX)
            {
                if (GameController.CurrentLevel.IsWall(minotaurX, minotaurY, Direction.Left) == false)
                {
                    newMinotaurX = minotaurX - 1;

                    // Add 1 to the move count.
                    currentMove = currentMove + 1;
                }
                else
                {
                    newMinotaurX = minotaurX;
                    moveFailed = true;
                }
            }

            // if Theseus is to the right of the Minotaur
            else if (theseusX > minotaurX)
            {
                if (GameController.CurrentLevel.IsWall(minotaurX, minotaurY, Direction.Right) == false)
                {
                    newMinotaurX = minotaurX + 1;
                    currentMove = currentMove + 1;
                }
                else
                {
                    newMinotaurX = minotaurX;
                    moveFailed = true;
                }
            }

            // Otherwise if the horizontal values match
            else
            {
                newMinotaurX = minotaurX;
            }


            // Compare vertical locations to get to Theseus

            // if theseus is above the minotaur
            if (theseusY < minotaurY)
            {
                if (GameController.CurrentLevel.IsWall(newMinotaurX, minotaurY, Direction.Up) == false)
                {
                    newMinotaurY = minotaurY - 1;
                    currentMove = currentMove + 1;
                }
                else
                {
                    newMinotaurY = minotaurY;
                }
            }


            // if Theseus is below the Minotaur
            else if (theseusY > minotaurY)
            {
                if (GameController.CurrentLevel.IsWall(newMinotaurX, minotaurY, Direction.Down) == false)
                {
                    newMinotaurY = minotaurY + 1;
                    currentMove = currentMove + 1;
                }
                else
                {
                    newMinotaurY = minotaurY;
                }
            }

            else
            {
                newMinotaurY = minotaurY;
            }

            // Check the vertical move is valid (no walls/out of bounds/etc)
            // if (!GameController.CurrentLevel.IsWall(newY, newX, horizontalMove))

            minotaurMoves[0][0] = newMinotaurX;

            minotaurMoves[0][1] = minotaurY;

            minotaurMoves[1][0] = newMinotaurX;

            minotaurMoves[1][1] = newMinotaurY;


            // This updates the starting positions of the minotaur, CHECK FOR CONFLICTS?
            GameController.MyMinotaur.YPosition = newMinotaurY;
            GameController.MyMinotaur.XPosition = newMinotaurX;

            moveFailed = false;

            return minotaurMoves;
        }



        // The Minotaur always moves twice so method returns an array with two sets of xy ints
        public int[][] Move () 
        {
            int[][] minotaurMoves = new int[2][];


            minotaurMoves = CompleteMove();

            return minotaurMoves;
        }
    }
    public class Exit : Character
    {
        public Exit()
            : base()
        {
            SpritePath += "\\exit.jpg";
        }
    }
}