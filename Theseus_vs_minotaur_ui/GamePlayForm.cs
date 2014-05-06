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
        GameController myGameController;   
        //initialize the variables to store cell dimensions
        int cellHeight;
        int cellWidth;
        int cellXCenter;
        int cellYCenter;
        //set the pixel width for walls
        int wallWidth = 5;
        //initialize the variables to store game images
        private Bitmap wallsAndExit;
        private Bitmap theseusImage;
        private Bitmap minotaurImage;
        //initialize xy coordinates used for moving characters
        int minotaurCurrentXPixel;
        int minotaurCurrentYPixel;
        int minotaurGoalXPixel;
        int minotaurGoalYPixel;
        int theseusCurrentXPixel;
        int theseusCurrentYPixel;
        int theseusGoalXPixel;
        int theseusGoalYPixel;


    
        public GamePlayForm(Level testLevel)
        {
            InitializeComponent();
            myGameController = new GameController();//these 2 lines will be replaced when further developed as form will take only a gameController.
            myGameController.CurrentLevel = testLevel;//Possibly not as an argument but by looking into the form that opens this one and copy reference.
            //get the images from disk
            theseusImage = new Bitmap(myGameController.MyTheseus.SpritePath);
            minotaurImage = new Bitmap(myGameController.MyMinotaur.SpritePath);
            

            
      

        }

        private void GamePlayForm_Load(object sender, EventArgs e)
        {
            cellWidth = ((this.pnlGameBoard.Width - wallWidth) / myGameController.CurrentLevel.GridSize[0]);
            cellHeight = ((this.pnlGameBoard.Height - wallWidth) / myGameController.CurrentLevel.GridSize[1]);
            cellXCenter = cellWidth / 2;
            cellYCenter = cellHeight / 2;
            //set their x,y pixels
            minotaurCurrentXPixel = calculateCharacterXPixel(myGameController.MyMinotaur.XPosition);
            minotaurCurrentYPixel = calculateCharacterYPixel(myGameController.MyMinotaur.YPosition);
            minotaurGoalXPixel = minotaurCurrentXPixel;
            minotaurGoalYPixel = minotaurCurrentYPixel;
            theseusCurrentXPixel = calculateCharacterXPixel(myGameController.MyTheseus.XPosition);
            theseusCurrentYPixel = calculateCharacterYPixel(myGameController.MyTheseus.YPosition);
            theseusGoalXPixel = theseusCurrentXPixel;
            theseusGoalYPixel = theseusCurrentYPixel;
            DrawWallsAndExit();
        }

        private void pnlGameBoard_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(wallsAndExit, 0, 0, wallsAndExit.Width, wallsAndExit.Height);
            DrawThesiusAndMinotaur(graphicsObj);
            MessageBox.Show(myGameController.MyMinotaur.XPosition.ToString()) // need to add in a thesus and minotaur in gc
; graphicsObj.DrawImage(minotaurImage, minotaurCurrentXPixel, minotaurCurrentYPixel, cellXCenter, cellYCenter);
         //  graphicsObj.DrawImage(minotaurImage, (cellWidth *0 ) + cellWidth / myGameController.CurrentLevel.GridSize[0], cellHeight * 0 + cellHeight / myGameController.CurrentLevel.GridSize[1], cellWidth / 2, cellHeight / 2);
            
            graphicsObj.Dispose();       
        }

        private void DrawThesiusAndMinotaur(Graphics graphicsobj)
        {

           // minotaurImage 
           // graphicsObj = Graphics.FromImage(minotaurImage);

        }
        private int calculateCharacterXPixel(int column)
        {
            column -= 1; //because character positions are 1 based not 0
            int result = cellWidth * column;            
            result += cellWidth;
            result /= myGameController.CurrentLevel.GridSize[0];
            return result;
        }
        
         private int calculateCharacterYPixel(int row)
        {
            int result = cellWidth * row;            
            result += cellHeight;
            result /= myGameController.CurrentLevel.GridSize[1];            
            return result;
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
            foreach (bool[] wallArray in myGameController.CurrentLevel.VerticalWallArray)
            {
                xposition = 0;
                foreach (bool wall in wallArray)
                {
                   if (wall == true)
                    {
                        lineRect = new Rectangle(xposition, yposition, wallWidth, cellHeight + wallWidth);
                        graphicsObj.FillRectangle(wallBrush, lineRect);
                    }
                    else
                    {
                        lineRect = new Rectangle(xposition, yposition, wallWidth, cellHeight);
                        graphicsObj.FillRectangle(gapBrush, lineRect);
                    }
                    xposition += cellWidth;
                }
                yposition += cellHeight;
            }
            yposition = 0;
            foreach (bool[] wallArray in myGameController.CurrentLevel.HorizontalWallArray)
            {
                xposition = wallWidth;
                foreach (bool wall in wallArray)
                {
                    if (wall == true)
                    {
                        lineRect = new Rectangle(xposition, yposition, cellWidth, wallWidth);
                        graphicsObj.FillRectangle(wallBrush, lineRect);
                    }
                    else
                    {
                        lineRect = new Rectangle(xposition, yposition, cellWidth - wallWidth, wallWidth);
                        graphicsObj.FillRectangle(gapBrush, lineRect);
                    }
                    xposition += cellWidth;
                }
                yposition += cellHeight;
            }
            graphicsObj.Dispose();
        }

        private void timerStep_Tick(object sender, EventArgs e)
        {
           
           if (theseusCurrentXPixel == theseusGoalXPixel && theseusCurrentYPixel == theseusGoalYPixel &&
               minotaurCurrentXPixel == minotaurGoalXPixel && minotaurCurrentYPixel == minotaurGoalYPixel)
           {
               timerStep.Stop();
           }
           else
           {
               MessageBox.Show("hi");
           }
            


        }
        

    }
}
