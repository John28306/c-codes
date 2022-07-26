using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_For_Bike
{
    internal class Provider
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int Phone_number { get; set; }
        public string BikeType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Provider(string fullname,string email,int phone,string bike,string username,string password)
        {
            Fullname = fullname;
            Email = email;
            Phone_number = phone;
            BikeType = bike;
            Username = username;
            Password = password;
        }





    }
}
