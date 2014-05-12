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

        private Level theLevel = null;

        public Level TheLevel
        {
            get { return theLevel; }
            set { theLevel = value; }
        }


        private User theUser = null;

        public User TheUser
        {
            get { return theUser; }
            set { theUser = value; }
        }


        public Score()
        {

            UserScore = userScore;
            LevelTime = levelTime;
        }

    }
}



