using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_vs_Minotaur_library
{
   class Character
    {
        private int xPosition, yPosition;
        // Level myLevel; Possible implementation??
        // image/skin?

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

    }

    class Theseus : Character
    {      /*  
        public bool Move (Direction direction)
        {
            // define variables
            int newX, newY;

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

            
        } */
    }

    class Minotaur : Character
    {/*
       
        public int[][] Move () // The Minotaur always moves twice so method returns an array with two sets of xy ints
        {
            // define variables
            int[][] minotaurMoves = new int[2][];
            int moveCount = 0;
            int theseusX, theseusY, newX, newY;
            Direction horizontalMove, verticalMove;
            
            // Find out where Theseus is
            theseusX = GameController.CurrentLevel.theseusXPosition; // Needs to refer to an instance somehow.
            theseusY = GameController.CurrentLevel.theseusYPosition;

            // two moves
            while (moveCount < 2)
            {
                // Compare horozontial locations to get to Theseus

                // if Theseus is to the left of the Minotaur
                if (theseusX < this.XPosition)
                {
                    // Subtract 1 from Minotaur X to move left
                    horizontalMove = Direction.Left;
                    newX = this.XPosition - 1;
                }
                // if Theseus is to the right of the Minotaur
                else if (this.XPosition < theseusX)
                {
                    // Add 1 to Minotaur X to move right
                    horizontalMove = Direction.Right;
                    newX = this.XPosition + 1;
                }
                // Otherwise if the horizontal values match
                else
                {
                    // In case a Y move can be made
                    horizontalMove = Direction.NoChange;
                    newX = this.XPosition;
                }

                // Check the horizontal move is valid (no walls/out of bounds/etc)
                if (horizontalMove != null && !GameController.CurrentLevel.IsWall(this.YPosition, newX, horizontalMove))
                {
                    minotaurMoves[0][0] = newX;
                    minotaurMoves[0][1] = this.YPosition;
                    moveCount++;
                }

                // Compare vertical locations to get to Theseus

                // if theseus is above the minotaur
                if (theseusY < this.YPosition)
                {
                    // Subtract 1 from Minotaur Y to move up
                    verticalMove = Direction.Up;
                    newY = this.YPosition - 1;
                }
                // if Theseus is below the Minotaur
                else if (this.YPosition < theseusY)
                {
                    // Add 1 to Minotaur Y to move down
                    verticalMove = Direction.Down;
                    newY = this.YPosition + 1;
                }
                else
                {
                    // In case an X move can be made
                    verticalMove = Direction.NoChange;
                    newY = this.YPosition;
                }

                // Check the vertical move is valid (no walls/out of bounds/etc)
                if (!GameController.CurrentLevel.IsWall(newY, newX, horizontalMove))
                {
                    minotaurMoves[1][0] = newX;
                    minotaurMoves[1][1] = newY;
                    moveCount++;
                }

                // If both horizontal and vertical moves failed, abort move and break from loop
                if (verticalMove == Direction.NoChange && horizontalMove == Direction.NoChange)
                {
                    break;
                }

            }

            return minotaurMoves;
        }*/
    }
}
