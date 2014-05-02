using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Theseus_vs_Minotaur_library;
using System.IO;
using System.Xml.Serialization;

namespace Theseus_vs_Minotaur_library
{
    public partial class userNameForm : Form
    {
        private string userName = "null";
        private StorageController storage;

        public userNameForm()
        {
            InitializeComponent();
            storage = new StorageController();
            

        }

        public string getUserName()
        {
            userName = textBox1.Text;
            return userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Catch user input from textbox 
            string userName = textBox1.Text; //getUserName();

            
          
            //if Validation passes
            if (!User.IsValidName(userName))
            {
                MessageBox.Show("Not Valid");
            }
            else
            {
                //ifthe username doesnt already exist
                if (!storage.isUserValid(userName))
                {

                    storage.CreateUser(userName);
                    storage.Save();
                    MessageBox.Show("this will redirect to main game page assigned to user " + userName);
                    Application.Exit(); // this needs to be directed to the main game page
                 
                  
                           

                }


                else
                {
                    MessageBox.Show("User name exits, Enter different name");
                    textBox1.Text = "";
                }

            }

            // for every user existing in the local users file
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

       /* private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storage.Save();
        }*/

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            LOGIN logform = new LOGIN();
            logform.ShowDialog();
            //storage.SerializeToXML();

        }


    }
}


