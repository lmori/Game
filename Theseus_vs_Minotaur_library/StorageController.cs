using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
//using System.Windows.Forms; needed?

namespace Theseus_vs_Minotaur_library
{

    [Serializable]
    public class StorageController : IStorageManagement
    {
        //private StorageController storage;


        private UserList users;
        private List<Level> levels;

        private Dictionary<String, int> levelDictionary;

        public IDictionary<String, int> LevelDictionary
        {
            get { return levelDictionary; }

        }

        public string serverRootLocation { get; set; }
        public string currentRootLocation { get; set; }

        //Constructor
        public StorageController()
        {

            users = new UserList();
            levels = new List<Level>();
            levelDictionary = new Dictionary<String, int>();

        }


        public UserList getUsers()
        {

            return users;
        }

        public IList<Level> getLevels()
        {
            return levels;
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


    }

}




