using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;

namespace Theseus_vs_Minotaur_library
{
    [Serializable]
    public class User
    {

        private string username;

        [XmlElement(ElementName = "Username")]
        public string Username
        {
            get { return username; }
            set
            {
                try
                {
                    if (IsValidName(value))
                        username = value;


                }
                catch (IOException exc)
                {
                    Console.WriteLine(exc.Message);


                }
            }
        }

        public User()
        {
            Username = "";
        }

        public User(String name)
        {

            Username = name;

        }

        public static bool IsValidName(String name)
        {

            if (string.IsNullOrEmpty(name))
                return false;
            else
            {
                // check for unusual characters(Not a complete character check do later with implementation)
                Regex validName = new Regex(@"([<>\?\*\\\""/\|])+");
                Match m = validName.Match(name);

                // if input is an empty string or the length is longer than 25 characters return false
                if (name == "" || name.Length > 25 || m.Success)
                    return false;

            }
            return true;
        }


    }

}


