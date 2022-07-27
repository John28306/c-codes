using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLT_FOR_BIKE
{
    internal class Bikebolt
    {
        public string Fullname { get; set; }
        public string Date_of_birth { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Bikebolt(string fullname,string DOB,string address,string username,string password)
        {
            Fullname = fullname;
            Date_of_birth = DOB;
            Address = address;
            Username = username;
            Password = password;
        }
        public Bikebolt()
        {

        }
    }
}
