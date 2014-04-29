using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_vs_Minotaur_library
{
    class Character
    {
        int xPosition, yPosition;
     //   Level myLevel; Possible implementation??
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
    {
        public bool Move (int newXPosition, int newYPosition, Direction direction)
        {

            // if (myLevel.IsWall(XPosition, YPosition, direction) == false)  Possible implementation??
            {
                // move the player
            }

            return true;
        }
    }

    class Minotaur : Character
    {

    }
}
