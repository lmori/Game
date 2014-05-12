using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theseus_vs_Minotaur_library;

namespace Theseus_vs_minotaur_ui
{
    public partial class LevelBrowser : Form
    {

        List<Level>[] currentDisplaySet;
        int currentPage;

        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }

        public List<Level>[] CurrentDisplaySet
        {
            get { return currentDisplaySet; }
            set { currentDisplaySet = value; }
        }
        
        // constructor
        public LevelBrowser()
        {
            InitializeComponent();

        }

        // Function that splits a long list of results into displayable chunks
        private List<Level>[] getDisplaySet(List<Level> levelList)
        {
            // Give these values names so they don't appear as magic numbers
            int numDisplayBoxes = 8;
            int numLevels = levelList.Count;
            int pageCount;
            List<Level>[] testOutputArray; // new output
            List<Level> pageContent;

            // calculate the number of required pages
            pageCount = (numLevels - 1) / numDisplayBoxes + 1;

            // prepare the output array
            testOutputArray = new List<Level>[pageCount];

            // if there are more results than can be displayed on one screen
            if (numLevels > numDisplayBoxes)
            {

                // For every level
                for (int i = 0; i < numLevels; i++)
                {
                    // if it's the first run through
                    if (i == 0)
                    {
                        // truncate the master list to only the first set of display results
                        pageContent = levelList.Take(numDisplayBoxes).ToList();
                        // set it as the first entry in the output array
                        testOutputArray[i] = pageContent;

                    }
                    else
                    {
                        // truncate the master list to only the next set of display results
                        pageContent = levelList.Skip(numDisplayBoxes * i).Take(numDisplayBoxes).ToList();
                        // set it as the next entry in the output array
                        testOutputArray[i] = pageContent;
                    }
                }

            }
            else
            {
                testOutputArray[0] = levelList;
            }

            // output the result
            return testOutputArray;
        }

        private void displayLevels(List<Level>[] displaySet)
        {
            // Get the first page of levels to display
            List<Level> pageLevels = displaySet[0];

            // cycle through each level and display the data in the form
           /* for (int i = 0; i < numLevels; i++){
            }*/
            

        }


    }
}
