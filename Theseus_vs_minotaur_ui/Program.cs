using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theseus_vs_Minotaur_library;
using System.IO;
using System.Xml.Serialization;

namespace Theseus_vs_minotaur_ui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Application.Run(new START());
            //Application.Run(new LOGIN());
           // Application.Run(new Form1());

            //First Page to be displayed

            
           

            bool[][] verWallArray = new bool[3][];
            verWallArray[0] = new bool[5] { true, false, false, true, false };
            verWallArray[1] = new bool[5] { true, false, true, false, false };
            verWallArray[2] = new bool[5] { true, false, false, true, false };

            bool[][] horWallArray = new bool[4][];
            horWallArray[0] = new bool[4] { true, true, true, false };
            horWallArray[1] = new bool[4] { false, true, false, true };
            horWallArray[2] = new bool[4] { false, true, false, true };
            horWallArray[3] = new bool[4] { true, true, true, false };

            int[] dim = { 4, 3 };

           

           Level testLevel = new Level("test.xml" , "First Level", "Me", 2, 1, 2, 3,4,2, verWallArray, horWallArray, dim,true);
           GameController.CurrentLevel = testLevel;

            //Testing level into dictionary and out to xml file
         //  LevelDictionary<string, Level> levelDictionary = new LevelDictionary<string, Level>();

            //is the filename the key?
         //  levelDictionary.Add(testLevel.LevelName, testLevel);

          // StreamWriter writer = new StreamWriter(@"h:\levels.xml");
          // XmlSerializer serialiser = new XmlSerializer(levelDictionary.GetType());
         //  serialiser.Serialize(writer, levelDictionary);

      
          

            //choose as needed to test...
           Application.Run(new LOGIN());
            //Application.Run(new GamePlayForm());
            //Application.Run(new SaveLevel());

            //Application.Run(new START());
           // Application.Run(new LOGIN());
            //Application.Run(new LevelBrowser());

            //Application.Run(new Form1());

        }
    }
}
