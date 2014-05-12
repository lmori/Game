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

namespace Theseus_vs_minotaur_ui
{
    public partial class SaveLevel : Form
    {
        StorageController storage = StorageController.Instance;
        public SaveLevel()
        {
            InitializeComponent();
        }

        private void SaveLevel_Load(object sender, EventArgs e)
        {

        }

        private void saveLevelOk_Click(object sender, EventArgs e)
        {
            //Call the save level method from storage controller when this part is created
            this.Hide();
          
        }
    }
}
