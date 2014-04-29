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
        public levelDesigner()
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
            newForm.Show();

        }
    }
}
