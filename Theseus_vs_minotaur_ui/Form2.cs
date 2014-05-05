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
    public partial class NewProject : Form
    {
	    public Boolean cancelled;
        public NewProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
		    cancelled = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancelled = true;
            this.Close();
        }

        private void NewProject_Load(object sender, EventArgs e)
        {

        }
    }
}
