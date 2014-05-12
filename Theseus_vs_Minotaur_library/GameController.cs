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
    class GameController : IStorageManagement
    {

        private static GameController instance = null;

        public static GameController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameController();
                }
                return instance;
            }
        }

        public GameController()
        {
            myTheseus = new Theseus(this);
            //savedGames = new SaveGameList();
        }

        Level currentLevel; //requires instance?
        Theseus myTheseus;
        Minotaur myMinotaur;
        List<Direction> moveList = new List<Direction>();
        //private SaveGameList savedGames;
        private List<SaveGame> savedGame = new List<SaveGame>();

        int timer;


        internal Theseus MyTheseus
        {
            get { return myTheseus; }
            set { myTheseus = value; }
        }

        internal Minotaur MyMinotaur
        {
            get { return myMinotaur; }
            set { myMinotaur = value; }
        }
        
        public int Timer
        {
            get { return timer; }
            set { timer = value; }
        }

        public Level CurrentLevel
        {
            get { return currentLevel; }
            set { currentLevel = value; }
        }

        public void LogMove(Direction direction)
        {
            this.moveList.Add(direction);
        }


        public void LoadGame()
        {
            deserializeGameFromXml(); // need to add more
        }

        public void  GetAllSaves(string levelName)
        {
            // for now void but returns a list of all the saved games
        }

        
        public void SaveGame(Level filename, User player, Score gameScore, int timer, List<Direction> movesOfThePlayer)
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
        public List<String> deserializeGameFromXml() //key is the filename which is assumed to be unique
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


        public void serializeGameToXml() // might want to change this to a list type
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