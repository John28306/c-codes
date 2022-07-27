using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLT_FOR_BIKE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> userSignin = new Dictionary<string, string>()
            {

            };
            Dictionary<string, string> provideSignin = new Dictionary<string, string>()
            {

            };
            while (true)
            {

            
                  Console.Write("What do you want to do..1...Signup...2.Login");
                  string op = Console.ReadLine();
                  if (op == "1")
                  {
                      Console.WriteLine("What category would you want to register under...1..User...2..Provider");
                      //OBJECTIVE
                      //USER SIGNUP
                      string op1 = Console.ReadLine();
                      if (op1 == "1")
                      {
                              Console.WriteLine("kindly fill the form below");
                              Console.WriteLine("Your Fullname");
                              string name = Console.ReadLine();
                              Console.WriteLine("Date_of_birth");
                              string DOB = Console.ReadLine();
                              Console.WriteLine("Address");
                              string address = Console.ReadLine();
                              Console.WriteLine("Username");
                              string username = Console.ReadLine();
                              Console.WriteLine("Password");
                              string password = Console.ReadLine();
                              List<Bikebolt> userinfo = new List<Bikebolt>()
                               {
                                   new Bikebolt(name,DOB,address,username,password),
                               };
                              userSignin.Add(username, password);
                          Console.WriteLine($"{name} {DOB} {address} {username} {password}");
                      }
                      //PROVIDER SIGNUP
                      else if (op1 == "2")
                      {
                                 Console.WriteLine("kindly fill the form below");
                                 Console.WriteLine("Your Fullname");
                                 string name = Console.ReadLine();
                                 Console.WriteLine("Date_of_birth");
                                 string DOB = Console.ReadLine();
                                 Console.WriteLine("Address");
                                 string address = Console.ReadLine();
                                 Console.WriteLine("Username");
                                 string username = Console.ReadLine();
                                 Console.WriteLine("Password");
                                 string password = Console.ReadLine();
                                 List<Provide> userinfo = new List<Provide>()
                                      {
                                          new Provide(name,DOB,address,username,password),
                                      };
                                 userSignin.Add(username, password);
                        Console.WriteLine(name, DOB, address, username, password);

                    }
                }


                //USER LOGIN
                //PROVIDER LOGIN


            }
        }
    }
}
