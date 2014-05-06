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

        
        //initialize the 
        int cellHeight;
        int cellWidth;
        
        //set the pixel width for walls
        int wallWidth = 5;

        private Bitmap wallsAndExit;
        private Bitmap theseusImage;
        private Bitmap minotaurImage;
    
        public GamePlayForm(Level testLevel)
        {
            InitializeComponent();
            myGameController = new GameController();
            myGameController.CurrentLevel = testLevel;      

        }

        private void GamePlayForm_Load(object sender, EventArgs e)
        {
            cellWidth = ((this.pnlGameBoard.Width - wallWidth) / myGameController.CurrentLevel.GridSize[0]);
            cellHeight = ((this.pnlGameBoard.Height - wallWidth) / myGameController.CurrentLevel.GridSize[1]);
            DrawWallsAndExit();
        }

        private void pnlGameBoard_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(wallsAndExit, 0, 0, wallsAndExit.Width, wallsAndExit.Height);
            DrawThesiusAndMinotaur();
            graphicsObj.DrawImage(minotaurImage, (cellWidth * 2) + cellWidth / myGameController.CurrentLevel.GridSize[0], cellHeight * 2 + cellHeight / myGameController.CurrentLevel.GridSize[1], cellWidth / 2, cellHeight / 2);

            graphicsObj.Dispose();       
        }

        private void DrawThesiusAndMinotaur()
        {
            Graphics graphicsObj;
            minotaurImage = new Bitmap(myGameController.MyMinotaur.SpritePath);
            graphicsObj = Graphics.FromImage(minotaurImage);

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
        

    }
}
