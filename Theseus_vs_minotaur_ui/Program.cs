using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theseus_vs_Minotaur_library;


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


            bool[][] verWallArray = new bool[3][];
            verWallArray[0] = new bool[4] { true, false, false, true };
            verWallArray[1] = new bool[4] { true, false, true, false };
            verWallArray[2] = new bool[4] { true, false, false, true };

            bool[][] horWallArray = new bool[4][];
            horWallArray[0] = new bool[3] { true, true, true };
            horWallArray[1] = new bool[3] { false, true, false };
            horWallArray[2] = new bool[3] { false, true, false };
            horWallArray[3] = new bool[3] { true, true, true };

            int[] dim = { 3, 3 };

            Level testLevel = new Level("", "", "", 2, 1, 2, 3, verWallArray, horWallArray, dim,true);

            //choose as needed to test...
            
            Application.Run(new GamePlayForm(testLevel));
            //Application.Run(new SaveLevel());

            //Application.Run(new START());
            //Application.Run(new LOGIN());
            //Application.Run(new LevelBrowser());

            //Application.Run(new Form1());

        }
    }
}
