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
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string fileName;
            fileName = fileNameTbx.Text;

            MessageBox.Show(String.Format(" {0} ", fileName));

        }
    }
}
