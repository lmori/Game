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
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;

namespace Theseus_vs_Minotaur_library
{
    public partial class START : Form
    {
        public START()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN log = new LOGIN();
            this.Hide();
            log.ShowDialog();
            //this.Show();
           
        }
    }
}
