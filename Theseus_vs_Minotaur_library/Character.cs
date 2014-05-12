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


        // The Minotaur always moves twice so method returns an array with two sets of xy ints
        public int[][] Move()
        {
            // Define variables
            int[][] minotaurMoves = new int[2][];
            minotaurMoves[0] = new int[2];
            minotaurMoves[1] = new int[2];

            int theseusX, theseusY;
            int minotaurX, minotaurY;
            int newMinotaurX = 0;
            int newMinotaurY = 0;

            int moveOneMinotaurX = 0;
            int moveOneMinotaurY = 0;

            int moveTwoMinotaurX = 0;
            int moveTwoMinotaurY = 0;

            int moveCount = 0;


            // Get the location of Theseus
            theseusX = GameController.MyTheseus.XPosition;
            theseusY = GameController.MyTheseus.YPosition;


            // Find out where Minotaur is.
            minotaurX = GameController.MyMinotaur.XPosition;
            minotaurY = GameController.MyMinotaur.YPosition;



            // If Theseus horizontal position is left of Minotaur.
            if (theseusX < minotaurX)
            {
                // Check if wall exists when Minotaur is moving left. NO WALL in way.
                if (GameController.CurrentLevel.IsWall(minotaurX, minotaurY,

Direction.Left) == false)
                {
                    // Set the new position for the minotaur.
                    moveOneMinotaurX = minotaurX - 1;

                    // Increase moveCount for minotaur.
                    moveCount = moveCount + 1;
                }

                // Wall is in the way moving horizontal.
                else
                {
                    // Set the new position for the minotaur.
                    moveOneMinotaurX = minotaurX;
                }
            }

            // If Theseus horizontal position is right of Minotaur.
            else if (theseusX > minotaurX)
            {
                // Check if wall exists when Minotaur is moving right. 
                // NO WALL in way.
                if (GameController.CurrentLevel.IsWall(minotaurX, minotaurY,

Direction.Right) == false)
                {
                    // Set the new position for the minotaur.
                    moveOneMinotaurX = minotaurX + 1;

                    // Increase moveCount for minotaur.
                    moveCount = moveCount + 1;
                }

                // Wall is in the way moving horizontal.
                else
                {
                    // Set the new position for the minotaur.
                    moveOneMinotaurX = minotaurX;
                }
            }

            // If Theseus horizontal position is the same as Minotaurs.
            else
            {
                // Set the new position for the minotaur.
                moveOneMinotaurX = minotaurX;
            }

            moveOneMinotaurY = minotaurY;


            // Either moveCount = 0, if no moves made or moveCount = 1 if 1 move made.


            // Try to move the minotaur vertically.
            // If Theseus is below the Minotaur.
            if (theseusY < minotaurY)
            {
                // Check if wall exists when Minotaur is moving Up. 
                // NO WALL in way.
                if (GameController.CurrentLevel.IsWall(moveOneMinotaurX, minotaurY,

Direction.Up) == false)
                {
                    // Set the new position for the minotaur.
                    newMinotaurY = minotaurY - 1;

                    // Increase moveCount for minotaur.
                    moveCount = moveCount + 1;

                    // If the moveCount is less than two, try to move horizontally.
                    if (moveCount < 2)
                    {
                        // If Theseus horizontal position is left of Minotaur.
                        if (theseusX < moveOneMinotaurX)
                        {
                            // Check if wall exists when Minotaur is moving right. 
                            // NO WALL in way.
                            if (GameController.CurrentLevel.IsWall(moveOneMinotaurX,

minotaurY, Direction.Right) == false)
                            {
                                // Set the new position for the minotaur.
                                moveOneMinotaurX = moveOneMinotaurX + 1;

                                // Increase moveCount for minotaur.
                                moveCount = moveCount + 1;
                            }
                        }

                        else if (theseusX > minotaurY)
                        {
                            // Check if wall exists when Minotaur is moving right. 
                            // NO WALL in way.
                            if (GameController.CurrentLevel.IsWall(moveOneMinotaurX,

minotaurY, Direction.Left) == false)
                            {
                                // Set the new position for the minotaur.
                                moveOneMinotaurX = moveOneMinotaurX - 1;

                                // Increase moveCount for minotaur.
                                moveCount = moveCount + 1;
                            }
                        }
                    }
                }
                else
                {
                    // Set the new position for the minotaur.
                    newMinotaurY = minotaurY;
                }
            }

            // If Theseus is above the Minotaur.
            else if (theseusY > minotaurY)
            {
                // Check if wall exists when Minotaur is moving Down. 
                // NO WALL in way.
                if (GameController.CurrentLevel.IsWall(moveOneMinotaurX, minotaurY,

Direction.Down) == false)
                {
                    // Set the new position for the minotaur.
                    newMinotaurY = minotaurY + 1;
                }
                else
                {
                    // Set the new position for the minotaur.
                    newMinotaurY = minotaurY;
                }
            }

            // If Theseus vertical position is the same as Minotaurs.
            else
            {
                // Set the new position for the minotaur.
                newMinotaurY = minotaurY;
            }



            GameController.MyMinotaur.XPosition = moveOneMinotaurX;
            GameController.MyMinotaur.YPosition = newMinotaurY;

            // Set the move 
            if (moveOneMinotaurX == minotaurX)
            {
                minotaurY = newMinotaurY;
            }

            minotaurMoves[0][0] = moveOneMinotaurX;
            minotaurMoves[0][1] = minotaurY;
            minotaurMoves[1][0] = moveOneMinotaurX;
            minotaurMoves[1][1] = newMinotaurY;

           

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