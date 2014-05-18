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
    public partial class LevelDesigner : Form
    {
        
        int numOfCellsV = 0;
        int numOfCellsH = 0;
        Character currentTool;
        Boolean isCreated = false;
        Rectangle[,] HorWalls;
        Rectangle[,] VerWalls;

        // After save button is clicked, these data need be stored to level object
        Boolean[,] Hor; //horizontal wall matrix
        Boolean[,] Ver; //vertical wall matrix

        int[] thesis_position = new int[2]; //theseus matrix position
        int[] minotaur_position = new int[2]; //minotaur matrix position

        public LevelDesigner()
        {
            InitializeComponent();
            // Don't use creatgraphic(). Use paint. Overwise graphic will dissapear each time form minmize.
        }


        private void exit_Click(object sender, EventArgs e) // when the exit button is clicked
        {
            DialogResult result = MessageBox.Show("Do you really want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();  //exits whole app for now, probably should go back to main menu
            }
        }

        private void createNewProject_Click(object sender, EventArgs e)
        {
            NewProject newForm = new NewProject();//Brings up form to put in name, grid size for new level
            newForm.ShowDialog();
            if (!newForm.cancelled)
            {
                // translate input into ints for horizontal and vertial range
                numOfCellsV = Convert.ToInt32(newForm.textBox3.Text);
                numOfCellsH = Convert.ToInt32(newForm.textBox4.Text);
                
                // create wall arrays for vertical and horizontal cells
                VerWalls = new Rectangle[numOfCellsV - 1, numOfCellsH];
                HorWalls = new Rectangle[numOfCellsV, numOfCellsH - 1];

                // What is this? A cell array?
                Hor = new Boolean[numOfCellsV, numOfCellsH + 1];
                Ver = new Boolean[numOfCellsV + 1, numOfCellsH];

                // initialise size variables for form
                int width = this.designCanvasPicBx.Width;
                int height = this.designCanvasPicBx.Height;
                int cellSizeV = height / numOfCellsV;
                int cellSizeH = width / numOfCellsH;

                // for every horizontal row of cells
                for (int j = 0; j < numOfCellsH; j++)
                {
                    //set the first set of vertical walls as solid?
                    Ver[0, j] = true;

                    // for every vertical column
                    for (int i = 0; i < numOfCellsV - 1; i++)
                    {
                        // create a wall
                        VerWalls[i, j] = new Rectangle(cellSizeV + i * cellSizeV, j * cellSizeH, 10, cellSizeH);
                        // set the wall boolean value to false?
                        Ver[i + 1, j] = false;
                    }

                    //set the last set of vertical walls as solid?
                    Ver[numOfCellsV, j] = true;
                }

                // for every column of vertical cells 
                for (int i = 0; i < numOfCellsV; i++)
                    // set the first set of horizontal walls as solid
                    Hor[i, 0] = true;

                // for every row of horizontal cells
                for (int j = 0; j < numOfCellsH - 1; j++)
                {
                    //for every column of vertical cells
                    for (int i = 0; i < numOfCellsV; i++)
                    {
                        // set a vertical wall
                        HorWalls[i, j] = new Rectangle(i * cellSizeV, cellSizeH + j * cellSizeH, cellSizeV, 10);
                        // and make it clear in the boolean array
                        Hor[i, j + 1] = false;
                    }
                }

                // for every vertical column of cells
                for (int i = 0; i < numOfCellsV; i++)
                    // set the last column of horizontal cells as solid?
                    Hor[i, numOfCellsH] = true;

                // set the new project as created
                isCreated = true;

                // refresh the form
                designCanvasPicBx.Invalidate();
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e) // paint the maze
        {
            // initialise drawing tools
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            Pen bb = new Pen(Color.Blue, 10);
            Brush blue = new SolidBrush(Color.Blue);
            g.Clear(Color.White);
            int width = this.designCanvasPicBx.Width;
            int height = this.designCanvasPicBx.Height;
            
            // if the new project has been initialised
            if (isCreated)
            {
                // draw a hardcoded map boundary?
                g.DrawLine(bb, 0, 0, width, 0); // 696 is the length of the sides
                g.DrawLine(bb, width, 0, width, height);
                g.DrawLine(bb, width, height, 0, height);
                g.DrawLine(bb, 0, height, 0, 0);

                // for every horizontal cell
                for (int j = 0; j < numOfCellsH; j++)
                {
                    // for every vertical cell
                    for (int i = 0; i < numOfCellsV - 1; i++)
                    {
                        // if there is no wall there, draw an empty rectangle
                        if (!Ver[i + 1, j])
                            g.DrawRectangle(p, VerWalls[i, j]);
                        // if there is supposed to be a wall there, draw a filled rectangle (redo this so blue isn't hardcoded in)
                        else
                            g.FillRectangle(blue, VerWalls[i, j]);
                    }
                }

                // for every horizontal cell
                for (int j = 0; j < numOfCellsH - 1; j++)
                {
                    // for every vertical cell
                    for (int i = 0; i < numOfCellsV; i++)
                    {
                        // if there is no wall there, draw an empty rectangle
                        if (!Hor[i, j + 1])
                            g.DrawRectangle(p, HorWalls[i, j]);
                        // if there is supposed to be a wall there, draw a filled rectangle (redo this so blue isn't hardcoded in)
                        else
                            g.FillRectangle(blue, HorWalls[i, j]);
                    }
                }
            }
            else
                g.DrawString("Nothing Yet", new Font("Tahoma", 40), Brushes.Black, new Point(50, 300));
        }


        private void designCanvasPicBx_Click(object sender, MouseEventArgs e) // find out which wall was clicked after the main canvas is hit
        {
            // for every horizontal cell
            for (int j = 0; j < numOfCellsH; j++)
            {
                // for every vertical cell
                for (int i = 0; i < numOfCellsV - 1; i++)
                {
                    // if the cell includes the area with the clicked co-ordinates?
                    if (VerWalls[i, j].Contains(e.X, e.Y))
                        // I don't know what this line refers to, any clues?
                        Ver[i + 1, j] = !Ver[i + 1, j];
                }
            }
            for (int j = 0; j < numOfCellsH - 1; j++)
            {
                for (int i = 0; i < numOfCellsV; i++)
                {
                    if (HorWalls[i, j].Contains(e.X, e.Y))
                        Hor[i, j + 1] = !Hor[i, j + 1];
                }
            }
            designCanvasPicBx.Invalidate();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Copy);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            designCanvasPicBx.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Form1_Load(object sender, EventArgs e) //Bring up a list of all users saved levels
        {
            designCanvasPicBx.AllowDrop = true;
        }




        private void import_Click(object sender, EventArgs e) //Will probably get rid of this button and just use Form1_Load instead
        {
		}
	
        private void export_Click(object sender, EventArgs e)
        {
          
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveLevel saveLev = new SaveLevel();
            saveLev.ShowDialog();
          

        }
    }
}
