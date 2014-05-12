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
        Boolean isCreated = false;
        Rectangle[,] HorWalls;
        Rectangle[,] VerWalls;
        Boolean[,] Hor;
        Boolean[,] Ver;

        public LevelDesigner()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really wanna exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();  //exits whole app for now, probably should go back to main menu
            }
        }

        private void createNewProject_Click(object sender, EventArgs e)
        {
            NewProject newForm = new NewProject();
            newForm.ShowDialog();
            if (!newForm.cancelled)
            {
                numOfCellsV = Convert.ToInt32(newForm.textBox3.Text);
                numOfCellsH = Convert.ToInt32(newForm.textBox4.Text);
                VerWalls = new Rectangle[numOfCellsV - 1, numOfCellsH];
                HorWalls = new Rectangle[numOfCellsV, numOfCellsH - 1];
                Hor = new Boolean[numOfCellsV, numOfCellsH + 1];
                Ver = new Boolean[numOfCellsV + 1, numOfCellsH];
                int width = this.pictureBox1.Width;
                int height = this.pictureBox1.Height;
                int cellSizeV = height / numOfCellsV;
                int cellSizeH = width / numOfCellsH;

                for (int j = 0; j < numOfCellsH; j++)
                {
                    Ver[0, j] = true;
                    for (int i = 0; i < numOfCellsV - 1; i++)
                    {
                        VerWalls[i, j] = new Rectangle(cellSizeV + i * cellSizeV, j * cellSizeH, 10, cellSizeH);
                        Ver[i + 1, j] = false;
                    }
                    Ver[numOfCellsV, j] = true;
                }

                for (int i = 0; i < numOfCellsV; i++)
                    Hor[i, 0] = true;

                for (int j = 0; j < numOfCellsH - 1; j++)
                {
                    for (int i = 0; i < numOfCellsV; i++)
                    {
                        HorWalls[i, j] = new Rectangle(i * cellSizeV, cellSizeH + j * cellSizeH, cellSizeV, 10);
                        Hor[i, j + 1] = false;
                    }
                }

                for (int i = 0; i < numOfCellsV; i++)
                    Hor[i, numOfCellsH] = true;

                isCreated = true;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            Pen bb = new Pen(Color.Blue, 10);
            Brush blue = new SolidBrush(Color.Blue);
            g.Clear(Color.White);
            int width = this.pictureBox1.Width;
            int height = this.pictureBox1.Height;
            if (isCreated)
            {
                g.DrawLine(bb, 0, 0, width, 0); // 696 is the length of the sides
                g.DrawLine(bb, width, 0, width, height);
                g.DrawLine(bb, width, height, 0, height);
                g.DrawLine(bb, 0, height, 0, 0);

                for (int j = 0; j < numOfCellsH; j++)
                {
                    for (int i = 0; i < numOfCellsV - 1; i++)
                    {
                        if (!Ver[i + 1, j])
                            g.DrawRectangle(p, VerWalls[i, j]);
                        else
                            g.FillRectangle(blue, VerWalls[i, j]);
                    }
                }
                for (int j = 0; j < numOfCellsH - 1; j++)
                {
                    for (int i = 0; i < numOfCellsV; i++)
                    {
                        if (!Hor[i, j + 1])
                            g.DrawRectangle(p, HorWalls[i, j]);
                        else
                            g.FillRectangle(blue, HorWalls[i, j]);
                    }
                }
            }
            else
                g.DrawString("Nothing Yet", new Font("Tahoma", 40), Brushes.Black, new Point(50, 300));
        }

        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {
            for (int j = 0; j < numOfCellsH; j++)
            {
                for (int i = 0; i < numOfCellsV - 1; i++)
                {
                    if (VerWalls[i, j].Contains(e.X, e.Y))
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
            pictureBox1.Invalidate();
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
            pictureBox1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
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
