using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_vs_Minotaur_library
{
    public class Score
    {
        
        private int userScore;

        public int UserScore
        {
            get { return userScore; }
            set { userScore = value; }
        }
       
        private int levelTime;

        public int LevelTime
        {
            get { return levelTime; }
            set { levelTime = value; }
        }

    }
}

