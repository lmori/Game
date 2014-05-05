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
        int cellHeight;
        int cellWidth;
        

        public GamePlayForm(Level testLevel)
        {
            InitializeComponent();
            myTestingLevel = testLevel;

        }

        private void GamePlayForm_Load(object sender, EventArgs e)
        {
            cellWidth = ((this.pnlGameBoard.Width - 10 * myTestingLevel.GridSize[0]) / myTestingLevel.GridSize[0]);
            cellHeight = ((this.pnlGameBoard.Height - 10 * myTestingLevel.GridSize[1]) / myTestingLevel.GridSize[1]);
            
        }

        private void pnlGameBoard_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            myPen.Width = 10;
            System.Drawing.Graphics formGraphics = this.pnlGameBoard.CreateGraphics();
           //Rectangle r = new Rectangle(5, 5, 50, 50);
          //  formGraphics.DrawRectangle(myPen, r);
            //formGraphics.DrawLine(myPen,0,0,cellWidth,0);
           // formGraphics.DrawLine(myPen, 0, 0, , );
            int xposition = 5;
            int yposition = 5;
            for (int i = 0; i < myTestingLevel.HorizontalWallArray.Length; i++)
            {
                xposition = 5;
                for (int j = 0; j < myTestingLevel.HorizontalWallArray[i].Length; j++ )
                {
                    
                    formGraphics.DrawLine(myPen, xposition, yposition, xposition + cellWidth, yposition);
                    xposition += cellWidth;
                }
                yposition += cellHeight;
            }

            xposition = 5;
            yposition = 5;
            for (int i = 0; i < myTestingLevel.VerticalWallArray.Length; i++)
            {
                yposition = 5;
                for (int j = 0; j < myTestingLevel.VerticalWallArray[i].Length; j++)
                {

                    formGraphics.DrawLine(myPen, xposition, yposition, xposition, yposition + cellHeight);
                    yposition += cellHeight;
                }
                xposition += cellWidth;
            }


            
        }

        private void GamePlayForm_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
