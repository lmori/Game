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
        string levelName;
        public string LevelName
        {
          get { return levelName; }
          set { levelName = value; }
        }
        
        string playerName;
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        int gameScore;
        public int GameScore
        {
          get { return gameScore; }
          set { gameScore = value; }
        }

        float getTimerSecs;

        public float GetTimerSecs
        {
            get { return getTimerSecs; }
            set { getTimerSecs = value; }
        }
      
    
    
    }

}
