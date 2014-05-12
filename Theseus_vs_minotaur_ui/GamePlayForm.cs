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
    public partial class GamePlayForm : Form
    {

        //GameController myGameController for future use ;
        Level myTestingLevel; //for test purposes

        //initialize the 
        int cellHeight;
        int cellWidth;

        //set the pixel width for walls
        int wallWidth = 5;

        private Bitmap wallsAndExit;


        public GamePlayForm(Level testLevel)
        {
            InitializeComponent();
            myTestingLevel = testLevel;

        }

        private void GamePlayForm_Load(object sender, EventArgs e)
        {
            cellWidth = ((this.pnlGameBoard.Width - wallWidth) / myTestingLevel.GridSize[0]);
            cellHeight = ((this.pnlGameBoard.Height - wallWidth) / myTestingLevel.GridSize[1]);
            DrawWallsAndExit();
        }

        private void pnlGameBoard_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(wallsAndExit, 0, 0, wallsAndExit.Width, wallsAndExit.Height);
            graphicsObj.DrawImage(wallsAndExit, 0, 0, wallsAndExit.Width, wallsAndExit.Height);
            graphicsObj.Dispose();
        }

        private void DrawWallsAndExit()
        {

            Graphics graphicsObj;
            wallsAndExit = new Bitmap(this.pnlGameBoard.Width, this.pnlGameBoard.Height,
                                        System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            graphicsObj = Graphics.FromImage(wallsAndExit);
            graphicsObj.Clear(Color.White);
            Brush wallBrush = new SolidBrush(Color.Black);
            Brush gapBrush = new SolidBrush(Color.LightGray);
            Rectangle lineRect;

            int xposition = 0;
            int yposition = 0;
            foreach (bool[] wallArray in myTestingLevel.VerticalWallArray)
            {
                xposition = 0;
                foreach (bool wall in wallArray)
                {
                    int height = yposition + cellHeight;
                    lineRect = new Rectangle(xposition, yposition, wallWidth, height);
                    if (wall == true)
                    {
                        graphicsObj.FillRectangle(wallBrush, lineRect);
                    }
                    else
                    {
                        graphicsObj.FillRectangle(gapBrush, lineRect);
                    }
                    xposition += cellWidth;
                }
                yposition += cellHeight;
            }
            yposition = 0;
            foreach (bool[] wallArray in myTestingLevel.HorizontalWallArray)
            {
                xposition = wallWidth;
                foreach (bool wall in wallArray)
                {
                    int width = xposition + cellWidth;
                    lineRect = new Rectangle(xposition, yposition, width, wallWidth);
                    if (wall == true)
                    {
                        graphicsObj.FillRectangle(wallBrush, lineRect);
                    }
                    else
                    {
                        graphicsObj.FillRectangle(gapBrush, lineRect);
                    }
                    xposition += cellWidth;
                }
                yposition += cellHeight;
            }
            graphicsObj.Dispose();
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            /* This will need to be added to the high scores dialog box form on load when it 
                is created to populate the high scores list box

            
             if (File.Exists(@"h:\scores.xml"))
             {
                 //get list of scores from xml file "users.xml"
                 var scoreList = storage.deserializeScoresFromXML();

//For every score in the list populate the list box with the user and the score - temp name of listbox = ListBoxScore
                 foreach (Score s in scoreList.Scores)
                 {
                     ListBoxScore.Items.Add(s.Username + s.userScore);

                 }

             }

             else {
                 ListBoxScore.Items.Add("No High Scores Exist" );
         }
     }*/
        }
    }
}
