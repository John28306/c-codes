using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_For_Bike
{
    internal class User
    {
        public string Fullname;
        public string Address;
        public string Email;
        public string Password;


        public User(string name, string address, string email, string password)
        {
            Fullname = name;
            Address = address;
            Email = email;
            Password = password;
        }
        public User()
        {

        }
    }
}
