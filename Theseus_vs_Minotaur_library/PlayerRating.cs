using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_vs_Minotaur_library
{
    public class PlayerRating : GameRating
    {

        private int theRating;

        public int TheRating
        {
            get { return theRating; }
            set { theRating = value; }
        }



    }
}


