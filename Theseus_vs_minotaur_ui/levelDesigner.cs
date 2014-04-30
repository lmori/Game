using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theseus_vs_minotaur_ui
{
    public partial class levelDesigner : Form
    {
        Graphics paper;

        public levelDesigner()
        {
            InitializeComponent();
            paper = pictureBox1.CreateGraphics();
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
            newForm.Show();

        }

        private void drawGrid()
        {
            int numOfCellsV = 7;
            int numOfCellsH = 10;
            int cellSizeV = 300 / numOfCellsV;
            int cellSizeH = 300 / numOfCellsH;
            Pen p = new Pen(Color.Blue);
            paper.Clear(Color.White);

            for (int i = 0; i < numOfCellsH; i++)
            {
                // Vertical
                paper.DrawLine(p, i * cellSizeH, 0, i * cellSizeH, numOfCellsV * cellSizeH);       
            }

            for (int i = 0; i < numOfCellsV; i++)
            {
                // Horizontal
                paper.DrawLine(p, 0, i * cellSizeV, numOfCellsH * cellSizeV, i * cellSizeV);
            }
        }

        // populate bool fill_in with true (alive) or false (dead)
        private void clearGrid()
        {
            for (int x = 0; x < 450; x = x + 10)
            {
                for (int y = 0; y < 450; y = y + 10)
                {
                  //  fill_in[x, y] = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            drawGrid();

            
        }
    }
}
