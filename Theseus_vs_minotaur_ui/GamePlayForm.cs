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
        //set the pixel width for walls
        int wallWidth = 5;
        //initialize the variables to store game images
        private Bitmap wallsAndExit;
        private Bitmap theseusImage;
        private Bitmap minotaurImage;
        //initialize xy coordinates used for tracking movement of characters
        int minotaurCurrentXPixel;
        int minotaurCurrentYPixel;
        int minotaurGoalXPixel;
        int minotaurGoalYPixel;
        int theseusCurrentXPixel;
        int theseusCurrentYPixel;
        int theseusGoalXPixel;
        int theseusGoalYPixel;
        //initialize more related varibles
        int stepCount = 0;
        int totalSteps = 2;

        //contructor. Will in future probably just set the gameController and get the images. may not take a level as an argument... level may be set elsewhere
        public GamePlayForm(Level testLevel)
        {
            InitializeComponent();
//lines of coded without tabbing like this is is generally going to change and is used for testing
myGameController = new GameController();//these 2 lines will be replaced when further developed as form will take only a gameController.
myGameController.CurrentLevel = testLevel;//Possibly not as an argument but by looking into the form that opens this one and copy reference.
            //get the images from disk
            theseusImage = new Bitmap(myGameController.MyTheseus.SpritePath);
            minotaurImage = new Bitmap(myGameController.MyMinotaur.SpritePath);
        }
        
        //sets the form varibles which are dependent on the users screen resolution.
        private void ScaleToScreen()
        {
            //calculate the cell dimensions based on screen size
            cellWidth = ((this.pnlGameBoard.Width - wallWidth) / myGameController.CurrentLevel.GridSize[0]);
            cellHeight = ((this.pnlGameBoard.Height - wallWidth) / myGameController.CurrentLevel.GridSize[1]);
            //set the x,y pixels of the characters
            minotaurCurrentXPixel = calculateCharacterXPixel(myGameController.MyMinotaur.XPosition);
            minotaurCurrentYPixel = calculateCharacterYPixel(myGameController.MyMinotaur.YPosition);
            minotaurGoalXPixel = minotaurCurrentXPixel;
            minotaurGoalYPixel = minotaurCurrentYPixel;
            theseusCurrentXPixel = calculateCharacterXPixel(myGameController.MyTheseus.XPosition);
            theseusCurrentYPixel = calculateCharacterYPixel(myGameController.MyTheseus.YPosition);
            theseusGoalXPixel = theseusCurrentXPixel;
            theseusGoalYPixel = theseusCurrentYPixel;
            //draw the walls and exit. This only needs to be done once and can be set as the panel background image
            DrawWallsAndExit();
            pnlGameBoard.BackgroundImage = wallsAndExit; // if this was in the paint event the level would flicker.
        }
        private void GamePlayForm_Load(object sender, EventArgs e)
        {
            ScaleToScreen(); 
            
move(Direction.Right);//for testing purposes
        }
        
        //paint method responsible for moving characters
        private void pnlGameBoard_Paint(object sender, PaintEventArgs e)
        {
            //this method will need to change. Non moving character flickers. Could draw it to walls & exit background image
            //in the move method? More research re flicker required
            Graphics graphicsObj = e.Graphics;            
            graphicsObj.DrawImage(minotaurImage, minotaurCurrentXPixel, minotaurCurrentYPixel, cellWidth / 2, cellHeight / 2);
            graphicsObj.DrawImage(theseusImage, theseusCurrentXPixel, theseusCurrentYPixel, cellWidth / 2, cellHeight / 2);
            graphicsObj.Dispose();       
        }
        
        //will be the method run by various movement events to start the game moving
        private void move(Direction direction)
        {
            //change the library data for the theseus first 
            myGameController.MyTheseus.Move(direction);
            // set the goal position of the theseus. The timer tick method runs until the goal and current position are the same.
            theseusGoalXPixel = calculateCharacterXPixel(myGameController.MyTheseus.XPosition);
            theseusGoalYPixel = calculateCharacterYPixel(myGameController.MyTheseus.YPosition);
            //reset the step count to 0 before running the timer. This is used to check the state of the incremental move of the character
            //vs the number of steps required
            int stepCount = 0;
            //start the timer - responsible for causing the form to repaint
            timerStep.Start();
            
            //similar pattern required twice for minotaur's two moves

        }
        //converts a column to a x pixel value
        private int calculateCharacterXPixel(int column)
        {
            column -= 1; //because character positions are 1 based not 0
            int result = cellWidth * column;
            //makes it so the character isn't hard up against the wall 
            result += cellWidth / 4;
            return result;
        }
        //converts a row to an y pixel value
         private int calculateCharacterYPixel(int row)
        {
            row -= 1; //because character positions are 1 based not 0
           int result = cellHeight * row;
           //makes it so the character isn't hard up against the wall
           result += cellHeight / 5;
           return result;
        }

        //update the walls and exit bitmap to reflect the level arrays
//currently only draws the walls.. Exit will be easy
        private void DrawWallsAndExit()
        {
            Graphics graphicsObj;
            //initialize a bitmap instance for the walls and exit
            wallsAndExit = new Bitmap(this.pnlGameBoard.Width, this.pnlGameBoard.Height, 
                                        System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //create a blank canvas
            graphicsObj = Graphics.FromImage(wallsAndExit);
            graphicsObj.Clear(Color.White);
            //create two brushes for walls. One which will draw black the other grey
            Brush wallBrush = new SolidBrush(Color.Black);
            Brush gapBrush = new SolidBrush(Color.LightGray);
            //create a rectangle which is used to draw lines. Chose rectangle as it draws from the top left corner 
            //lines draw from the middle of the line
            Rectangle lineRect;
            
            //start at the top left corner
            int xposition = 0;
            int yposition = 0;
            //iterate through the horizontal array picking out the wall arrays for each row
            foreach (bool[] wallArray in myGameController.CurrentLevel.VerticalWallArray)
            {
                //start at the left hand side for each wall array
                xposition = 0;
                //iterate through each wall in the wall array 
                foreach (bool wall in wallArray)
                {
                   //if it is a wall draw a black line using the wall brush. 
                    if (wall == true)
                    {
                        //draw the line slighly longer if it is a wall
                        lineRect = new Rectangle(xposition, yposition, wallWidth, cellHeight + wallWidth);
                        graphicsObj.FillRectangle(wallBrush, lineRect);
                    }
                    //otherwise use the lighter colored brush
                    else
                    {
                        lineRect = new Rectangle(xposition, yposition, wallWidth, cellHeight);
                        graphicsObj.FillRectangle(gapBrush, lineRect);
                    }
                    //move starting point to the right 
                    xposition += cellWidth;
                }
                //start drawing on the next row. Walls by are drawn by each row like so:
                // | | | | 
                // | | | 
                //not
                // | |
                // | |
                // |
                yposition += cellHeight;
            }
            
            //follow the same pattern for the horizontal walls
            yposition = 0;
            xposition = 0;
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

//this timer's event method is responsible for redrawing characters to create movement.
//currently is hard coded and needs more work 
        private void timerStep_Tick(object sender, EventArgs e)
        {
           
           if (theseusCurrentXPixel == theseusGoalXPixel && theseusCurrentYPixel == theseusGoalYPixel &&
               minotaurCurrentXPixel == minotaurGoalXPixel && minotaurCurrentYPixel == minotaurGoalYPixel)
           {
               timerStep.Stop();
           }
           else
           {
               
               if (stepCount <= totalSteps)
               {
                   int stepSize = (theseusGoalXPixel - theseusCurrentXPixel) / totalSteps;
                   if (stepCount == totalSteps)
                   {
                       theseusCurrentXPixel = theseusGoalXPixel;
                   }
                   else
                   {
                       theseusCurrentXPixel += stepSize;
                   }
                   stepCount += 1;
                   pnlGameBoard.Invalidate();
               }
           }
            


        }
        //rescales the form when the user resizes the window
        private void GamePlayForm_Resize(object sender, EventArgs e)
        {
            ScaleToScreen();
        }
        

    }
}
