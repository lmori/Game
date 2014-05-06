using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Theseus_vs_Minotaur_library

    
{
    public class UserList{
   
        private List<User> users=new List<User>();

        public List<User> Users
        {
          get { return users; }
          set { users = value; }
        }
   
        public UserList()
        {
     

        }
    }
}


