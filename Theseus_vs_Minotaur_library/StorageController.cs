using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml;
using System.IO;


namespace Theseus_vs_Minotaur_library
{


    public class StorageController : IStorageManagement
    {

        private static StorageController instance = null;

        public static StorageController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StorageController();
                }
                return instance;
            }
        }

        //Constructor
        public StorageController()
        {
            currentUser = new User();
            users = new UserList();
            scores = new ScoreList();
            

           
            levelDictionary = new LevelDictionary<String, Level>();
        }


        private UserList users;
        private ScoreList scores;
       


        private User currentUser = null;

        public User CurrentUser
        {
            get
            {

                return currentUser;
            }

        }

        
        private LevelDictionary<String, Level> levelDictionary;
       
        public LevelDictionary<String, Level> LevelDictionary
        {
            set { levelDictionary = value; }
            get { return levelDictionary; }

        }

        public string serverRootLocation { get; set; }
        public string currentRootLocation { get; set; }





        public UserList getUsers()
        {

            return users;
        }

        public LevelDictionary<String, Level> getLevels()
        {
            return levelDictionary;
        }



//Serialize and deserialise methods can be re written to take a type parameter so that the methods are only written once instead of for each object 


//User Methods ----------------------------------------------------------------------------------------------->

        public void CreateUser(String name)
        {
           
            var theUser = new User(name);


            //Check if file exists
            if (File.Exists(@"users.xml"))
            {
                var userList = deserializeFromXML();

                //Add the users from the xml file to the list
                foreach (User u in userList.Users)
                {
                    users.Users.Add(u);


                }
            }
            //Add the new user to the list
            users.Users.Add(theUser);
        }


        //Save the userlist to the xml file
        public void SerializeToXML()
        {

            XmlSerializer serializer = new XmlSerializer(users.GetType()); // getting the users 
            serializer.Serialize(new StreamWriter(@"users.xml"), users); // adding values to xml file
            Console.WriteLine(users);

        }

        //Retrieve users from the xml file and return the userlist

        public UserList deserializeFromXML()
        {

            var userList = new UserList();

            XmlSerializer deserializer = new XmlSerializer(typeof(UserList));
            using (StreamReader textReader = new StreamReader(@"users.xml")) //changed path from absolute to relative paths
                userList = (UserList)deserializer.Deserialize(textReader);

                textReader.Close();


            }

            return userList;
        }


        public void Save()
        {
            SerializeToXML();
        }

        //Validation on new user form input
        public bool isUserValid(string userInput)
        {

            bool userVal = false;

            UserList userList = getUsers();
            foreach (User u in userList.Users)
            {

                // check the input matches the username 
                if (userInput == u.Username)
                {
                    userVal = true;
                    

                }
                else
                {
                    //if none match return false
                    userVal = false;
                    
                }
            }
            return userVal;

        }
//Level Methods ----------------------------------------------------------------------------------------------->


        //Save the levels dictionary to xml file
        public void SerializeLevelsToXML()
        {

           
            StreamWriter writer = new StreamWriter(@"h:\levels.xml");
            XmlSerializer serialiser = new XmlSerializer(levelDictionary.GetType());
            serialiser.Serialize(writer, levelDictionary);

        }

        //Retrieve the levels from xml file and return level dictionary
        public LevelDictionary<String, Level> deserializeLevelsFromXML()// get levels from xml file
        {

            var level = new LevelDictionary<String, Level>();

            XmlSerializer deserializer = new XmlSerializer(levelDictionary.GetType());
            using (StreamReader textReader = new StreamReader(@"h:\levels.xml"))
            {
                level = (LevelDictionary<string, Level>)deserializer.Deserialize(textReader);

                textReader.Close();
            }
            return level;

        }

        //Saves the level from level designer - saveLevel form 
        public void SaveLevel(String fileName, String levelName, String creatorName, int minotaurXPosition, int minotaurYPosition,
                    int theseusXPosition, int theseusYPosition, int exitXPosition, int exitYPosition, bool[][] verticalWallArray, bool[][] horizontalWallArray, int[] gridSize, bool levelFinished)
         {
            //file name is the same as the level name

             Level lev = new Level(fileName, levelName, creatorName, minotaurXPosition, minotaurYPosition, theseusXPosition,
                 theseusYPosition, exitXPosition, exitYPosition, verticalWallArray, horizontalWallArray, gridSize, levelFinished);
            
            lev.FileName = fileName;
            lev.LevelName = levelName ;


            lev.CreatorName = creatorName;
            lev.MinotaurXPosition = minotaurXPosition;
            lev.TheseusXPosition = theseusXPosition;
            lev.MinotaurYPosition = minotaurYPosition;
            lev.TheseusYPosition = theseusYPosition;
            lev.ExitXPosition = exitXPosition;
            lev.ExitYPosition = exitYPosition;
            lev.VerticalWallArray = verticalWallArray;
            lev.HorizontalWallArray = horizontalWallArray;

            lev.GridSize = gridSize;
            lev.IsLevelFinished = levelFinished;

            //Retrieve the levels from the xml file and return to levelDictionary
            levelDictionary = deserializeLevelsFromXML();

            // add new saved level to dictionary
            levelDictionary.Add(levelName, lev);

            
            //Save everything in the level Dictionary to xml
            SerializeLevelsToXML();

        }

        //deserialized levels, adds to the dictionary and returns the level from the key value input parameter
        public Level getLevel(string key)
        {
            
            levelDictionary = deserializeLevelsFromXML();
            Level theLevel;
            levelDictionary.TryGetValue(key, out theLevel);


            return theLevel;    
        }



//Score Methods---------------------------------------------------------------------------------------------->
        //Save all score values from the score class to xml 
        public void SerializeScoresToXML()
        {

            XmlSerializer serializer = new XmlSerializer(scores.GetType()); // getting the users 
            serializer.Serialize(new StreamWriter(@"h:\scores.xml"), scores); // adding values to xml file
            Console.WriteLine(scores);
        }

        // get scores from the xml file and return the list of scores
        public ScoreList deserializeScoresFromXML()
        {

            var scoreList = new ScoreList();

            XmlSerializer deserializer = new XmlSerializer(typeof(ScoreList));
            using (StreamReader textReader = new StreamReader(@"h:\scores.xml"))
            {
                scoreList = (ScoreList)deserializer.Deserialize(textReader);

                textReader.Close();


            }

            return scoreList;
        }

        //Calculates and adds user score
        public void addScore(int userScore, int levelTime, Level level, StorageController currentUser)
        {
            //create instance
            Score score = new Score();

            //get the levelTime
            score.LevelTime = levelTime;

            // Get and assign the current level (game controller needs to be a singleton pattern otherwise more then 1 instance will be made to access current Level like shown below)
           // GameController game = new GameController();
            score.TheLevel = GameController.CurrentLevel;

            //get and assign the user
            score.TheUser = this.CurrentUser;

            //Calculate score
            var multiplier = 100 / score.LevelTime;

            //update usercore
            score.UserScore = 10000 * multiplier;


        }
        
    }

}




