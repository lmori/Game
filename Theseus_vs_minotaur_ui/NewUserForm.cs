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

namespace Theseus_vs_minotaur_ui
{
    public partial class userNameForm : Form
    {
        private string userName = "null";
        StorageController storage = StorageController.Instance;
       
        public userNameForm()
        {
            InitializeComponent();
          
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
                  

                    storage.CurrentUser.Username = userName;
                    START start = new START();
                    
                    start.ShowDialog();

                 

                  
                  
                 
                 
                  
                           

                }


                else
                {
                    MessageBox.Show("User name exits, Enter different name");
                    textBox1.Text = "";
                }

            }

        
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN logform = new LOGIN();
            logform.ShowDialog();
            //storage.SerializeToXML();
            
        }


    }
}


