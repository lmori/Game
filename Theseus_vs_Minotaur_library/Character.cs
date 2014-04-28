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
        public bool Move (int newXPosition, int newYPosition)
        {

            if (CanMove(Direction direction) == true) 
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
