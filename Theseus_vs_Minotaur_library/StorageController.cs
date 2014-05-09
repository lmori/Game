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

    [Serializable]
     public class StorageController 
    {

        private static StorageController instance = null;

        public static StorageController Instance
        {
            get {
                if (instance == null)
                {
                    instance = new StorageController();
                }
                return instance; }
        }

        //Constructor
        public StorageController()
        {
            currentUser = new User();
            users = new UserList();
            levelDictionary = new Dictionary<String, Level>();
        }
   
       
        private UserList users;

        private User currentUser = null;

        public User CurrentUser
        {
            get { 
                
                return currentUser; }
           
        }

       

        private Dictionary<String, Level> levelDictionary;

        public Dictionary<String, Level> LevelDictionary
        {
            get { return levelDictionary; }

        }

        public string serverRootLocation { get; set; }
        public string currentRootLocation { get; set; }

       
      


        public UserList getUsers()
        {

            return users;
        }

        public Dictionary<String, Level> getLevels()
        {
            return levelDictionary;
        }
      

        public void CreateUser(String name)
        {
            var theUser = new User(name);
            
           
                
            if (File.Exists(@"h:\users.xml"))
            {
                var userList = deserializeFromXML();
               
                foreach (User u in userList.Users)
                {
                    users.Users.Add(u);


                }
            }
            users.Users.Add(theUser);
        }
              


        public void SerializeToXML()
        {

            XmlSerializer serializer = new XmlSerializer(users.GetType()); // getting the users 
            serializer.Serialize(new StreamWriter(@"h:\users.xml"), users); // adding values to xml file
            Console.WriteLine(users);

        }


        public UserList deserializeFromXML()// get usernames from the xml file and populate the list box 
        // when next the application is executed the follo. time
        {

            var userList = new UserList();

            XmlSerializer deserializer = new XmlSerializer(typeof(UserList));
            using (StreamReader textReader = new StreamReader(@"h:\users.xml"))
            {
                userList = (UserList)deserializer.Deserialize(textReader);

                textReader.Close();


            }

            return userList;
        }


        public void Save()
        {
            SerializeToXML();
        }


        public void getLevel()
        {
            //get level file from the current root directory

            //currentRootLocation/levels/playable/<levelID>.lvl

            //deserialize the level file into a level object


            //return the level object
        }

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
                    //MessageBox.Show("User exists. Enter a different name");

                }
                else
                {
                    userVal = false;
                    //if none match return false
                    Console.WriteLine("User doesnt exist");
                }
            }
            return userVal;

        }

        public void SerializeLevelsToXML()
        {

            XmlSerializer serializer = new XmlSerializer(levelDictionary.GetType()); // getting the users 
            serializer.Serialize(new StreamWriter(@"h:\levels.xml"), levelDictionary); // adding values to xml file
            Console.WriteLine(levelDictionary);

        }
        public void SaveLevel(String fileName, String levelName, String creatorName, int minotaurXPosition, int minotaurYPosition,
                    int theseusXPosition, int theseusYPosition, bool[][] verticalWallArray, bool[][] horizontalWallArray, int[] gridSize, bool levelFinished)
         {
            //file name is the same as the level name

             Level lev = new Level(fileName, levelName, creatorName, minotaurXPosition, minotaurYPosition, theseusXPosition, theseusYPosition, 
                 verticalWallArray, horizontalWallArray, gridSize, levelFinished);

            lev.FileName = fileName;
           lev.LevelName = levelName ;
           lev.CreatorName = creatorName;
            lev.MinotaurXPosition = minotaurXPosition;
            lev.TheseusXPosition = theseusXPosition;
            lev.MinotaurYPosition = minotaurYPosition;
            lev.TheseusYPosition = theseusYPosition;
            lev.VerticalWallArray = verticalWallArray;
            lev.HorizontalWallArray = horizontalWallArray;

            lev.GridSize = gridSize;
            lev.IsLevelFinished = levelFinished;
           
            // add level to dictionary
            levelDictionary.Add(levelName,lev);

            SerializeLevelsToXML();



         }

        public Dictionary<String, int> deserializeLevelsFromXML()// get levels from xml file
        {

            var level = new Dictionary<String, int>();

            XmlSerializer deserializer = new XmlSerializer(typeof(Level));
            using (StreamReader textReader = new StreamReader(@"h:\users.xml"))
            {
                level = (Dictionary<String, int>)deserializer.Deserialize(textReader);

                textReader.Close();
            }
            return level;
        }
    }

}




