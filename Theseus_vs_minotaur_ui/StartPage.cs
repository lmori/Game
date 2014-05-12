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
//using Theseus_vs_minotaur_ui;



namespace Theseus_vs_minotaur_ui
{
    public partial class START : Form
    {
        StorageController storage = StorageController.Instance;

       
        public START()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            
            this.usernamebox.Text = "Logged in As " + storage.CurrentUser.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GamePlayForm lBrow = new GamePlayForm();//for demo purposes
            this.Hide();
            lBrow.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LevelDesigner lDes = new LevelDesigner();
            this.Hide();
            lDes.ShowDialog();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void username_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
