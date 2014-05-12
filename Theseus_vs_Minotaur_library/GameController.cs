using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;


namespace Theseus_vs_Minotaur_library
{

    public static class GameController : IStorageManagement
    {
        static Level currentLevel;
        static Theseus myTheseus = new Theseus();
        static Minotaur myMinotaur = new Minotaur();
        static Exit myExit = new Exit();
        static List<Direction> moveList = new List<Direction>();
        static float timer;

        public static Theseus MyTheseus

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



        public static void LoadGame()
        {
            deserializeGameFromXml(); // need to add more
        }

        public static void GetAllSaves(string levelName)
        {
            // for now void but returns a list of all the saved games
        }

        
        public static void SaveGame(Level filename, User player, Score gameScore, int timer, List<Direction> movesOfThePlayer)
        {
            SaveGame game = new SaveGame();
            game.LevelName = filename;                           // needs to deserialise all this
            game.PlayerName = player;
            game.GameScore = gameScore;
            game.GetTimerSecs = timer;
            game.MovesList = movesOfThePlayer;

            savedGame.Add(game);
            serializeGameToXml();
        }

        //  JUST SEEMED CONVENIENT TO HAVE THE BELOW DE/SERIALISED METHOD HERE FOR NOW
        public static List<String> deserializeGameFromXml() //key is the filename which is assumed to be unique
        {
            var game = new List<String>();
            XmlSerializer deserializeGame = new XmlSerializer(typeof(SaveGame));
            using (StreamReader text = new StreamReader(@"h:\game.xml"))
            {
                game = (List<String>)deserializeGame.Deserialize(text);
                text.Close();
            }
            return game;

        }


        public static void serializeGameToXml() // might want to change this to a list type
        {
            SaveGame savedGame = new SaveGame();
            XmlSerializer serializeGame = new XmlSerializer(savedGame.GetType());
            serializeGame.Serialize(new StreamWriter(@"h:\game.xml"), savedGame);
            Console.WriteLine(savedGame);
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