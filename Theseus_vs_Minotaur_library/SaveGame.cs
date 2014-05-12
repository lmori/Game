/* SaveGame - Saves a game played with all its information. That is the day and amount of time played
              for that game by a player. */
/* @author(s) - Team A2 */
/* Created on - 8th April 2014*/
/* Last Revised on -  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace Theseus_vs_Minotaur_library
{

    public class SaveGame
    {
        Level levelName;
        public Level LevelName
        {
          get { return levelName; }
          set { levelName = value; }
        }
        
        User playerName = null;
        public User PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        Score gameScore;
        public Score GameScore
        {
          get { return gameScore; }
          set { gameScore = value; }
        }

        int getTimerSecs;

        public int GetTimerSecs
        {
            get { return getTimerSecs; }
            set { getTimerSecs = value; }
        }

        private List<Direction> movesList = new List<Direction>();    
         
        public List<Direction> MovesList
        {
          get { return movesList; }
          set { movesList = value; }
        }

        public SaveGame(Level levelName)
        {
            LevelName = levelName;
        }

        public SaveGame()
        {
        }
    
    }

}
