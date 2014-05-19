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
    public partial class LOGIN : Form
    {
        
      private StorageController storage = StorageController.Instance; 

        public LOGIN()
        {
            InitializeComponent();
        }

   
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"users.xml")){
            //get list of users from xml file "users.xml"
            var userList = storage.deserializeFromXML();
           
            //For every user in the list add to populate the list box 
            foreach (User u in userList.Users)
            {
                UsersBox.Items.Add(u.Username);
                
            }

           
        }}
        //return the selected user from the listbox
        public string getSelected()
        {
            var selected = UsersBox.SelectedItem.ToString();
            return selected;
        }
        private void UserBut_Click(object sender, EventArgs e)
        {
            userNameForm userForm = new userNameForm();
            this.Hide();
            userForm.ShowDialog();
        }

        private void OK_Click(object sender, EventArgs e)
        {   
            

            //if no user has been selected show message
            if (UsersBox.SelectedIndex == -1)
                MessageBox.Show("You havent selected a user");
               
            else
            {
                var selected = getSelected();

                storage.CurrentUser.Username = selected; 

                START start = new START();
                this.Hide();
                start.ShowDialog();
                
            }
        }


    }
}
