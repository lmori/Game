using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_vs_Minotaur_library
{
    public static class GameController
    {
        static Level currentLevel;
        static Theseus myTheseus = new Theseus();
        static Minotaur myMinotaur = new Minotaur();
        static Exit myExit = new Exit();
        static List<Direction> moveList = new List<Direction>();
        static float timer;

        public static Theseus MyTheseus
        {
            get { return myTheseus; }
            set { myTheseus = value; }
        }

        public static Minotaur MyMinotaur
        {
            get { return myMinotaur; }
            set { myMinotaur = value; }
        }

        public static Exit MyExit
        {
            get { return GameController.myExit; }
            set { GameController.myExit = value; }
        }

        
        public static float Timer
        {
            get { return timer; }
            set { timer = value; }
        }

        public static Level CurrentLevel
        {
            get { return currentLevel; }
            set 
            {
                currentLevel = value;
                //set the minotaur and theseus positions to the levels specified start positions
                myMinotaur.XPosition = currentLevel.MinotaurXPosition;
                myMinotaur.YPosition = currentLevel.MinotaurYPosition;
                myTheseus.XPosition = currentLevel.TheseusXPosition;
                myTheseus.YPosition = currentLevel.TheseusYPosition;
                myExit.XPosition = currentLevel.ExitXPosition;
                myExit.YPosition = currentLevel.ExitYPosition;
                
            }
        }

        public static void LogMove(Direction direction)
        {
            moveList.Add(direction);
        }

        public static bool CheckGameWon()
        {
            bool result;
            if (MyExit.XPosition == MyTheseus.XPosition)
            {
                if (MyExit.YPosition == myTheseus.YPosition)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool CheckGameLost()
        {
            bool result;
            if (MyMinotaur.XPosition == MyTheseus.XPosition)
            {
                if (MyMinotaur.YPosition == myTheseus.YPosition)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

    }

    public enum Direction
    {
        NoChange,
        Right,
        Left,
        Up,
        Down        
    }
}