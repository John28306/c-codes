using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_For_Bike
{
    class program
    {
        static void Main(String[] args)
        {
            //for providers
            Dictionary<string, string> providelogin = new Dictionary<string, string>();
            Dictionary<string, string> providepassword = new Dictionary<string, string>();

            List<string> Name = new List<string>();
            List<string> Address = new List<string>();
            List<string> Type = new List<string>();
            List<string> Age = new List<string>();
            List<string> Nin = new List<string>();
            List<string> Password = new List<string>();

            //for users
            Dictionary<string, string> userlogin = new Dictionary<string, string>();
            Dictionary<string, string> userpass = new Dictionary<string, string>();
            List<string> userName = new List<string>();
            List<string> userAddress = new List<string>();
            List<string> userAge = new List<string>();
            List<string> userPassword = new List<string>();

            while (true)
            {
                Console.WriteLine("what would you want to do....1.Register....2.Login...3.Retrieve Password");
                string op1 = Console.ReadLine();
                if (op1 == "1")
                {
                    Console.WriteLine("what would you want to register as....1.Provider...2.User");
                    string op2 = Console.ReadLine();
                    if (op2 == "1")
                    {
                        Console.WriteLine("kindly fill the form Below");
                        try
                        {
                            Console.WriteLine("Your Name");
                            string name = Console.ReadLine();
                            Name.Add(name);

                            Console.WriteLine("Your Address");
                            string address = Console.ReadLine();
                            Address.Add(address);

                            Console.WriteLine("Your bike type,eg tricycle etc");
                            string type = Console.ReadLine();
                            Type.Add(type);

                            Console.WriteLine("Your Age");
                            string age = Console.ReadLine();
                            Age.Add(age);

                            Console.WriteLine("Your Nin");
                            string nin = Console.ReadLine();
                            Nin.Add(nin);

                            Console.WriteLine("Select Password");
                            string pass = Console.ReadLine();
                            Password.Add(pass);

                            providelogin.Add(name, pass);
                            //providepassword.Add(pass, name);
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err);
                        }
                        finally
                        {
                            Console.WriteLine("thanks For registering,We will get back to you");
                        }

                    }

                    else if (op2 == "2")
                    {
                        Console.WriteLine("kindly fill the form Below");
                        try
                        {
                            Console.WriteLine("Your Name");
                            string username = Console.ReadLine();
                            userName.Add(username);

                            Console.WriteLine("Your Address");
                            string useraddress = Console.ReadLine();
                            userAddress.Add(useraddress);

                            Console.WriteLine("Your Age");
                            string age = Console.ReadLine();
                            userAge.Add(age);

                            Console.WriteLine("Enter preffered Password");
                            string userpassword = Console.ReadLine();
                            userPassword.Add(userpassword);


                            userlogin.Add(username, userpassword);
                            userpass.Add(userpassword, username);
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err);
                        }
                        finally
                        {
                            Console.WriteLine("thanks For registering and enjoy your ride");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Select A Valid Option");
                    }

                }

                else if (op1 == "2")
                {
                    Console.WriteLine("Please choose Login type....1.Provider...2.User");
                   
                        string op2 = Console.ReadLine();
                        if (op2 == "1")
                        {
                        Console.WriteLine("Enter User name");
                            string provide = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string passw= Console.ReadLine();
                            if (providelogin.ContainsKey(provide) && providepassword.ContainsKey(passw))
                            {
                                Console.WriteLine("Login Successful");
                            }
                            else if (!providelogin.ContainsKey(provide) && providepassword.ContainsKey(passw))
                            {
                                Console.WriteLine("Incorrect Username");
                            }
                            else if (providelogin.ContainsKey(provide) && !providepassword.ContainsKey(passw))
                            {
                                Console.WriteLine("Incorrect Password");
                            }

                        else if (op2 == "2")
                        {
                            Console.WriteLine("Enter User name");
                            string user = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string userpassw = Console.ReadLine();
                            if (userlogin.ContainsKey(user) && userpass.ContainsKey(userpassw))
                            {
                                Console.WriteLine("Login Successful");
                            }
                            else if (!userlogin.ContainsKey(user) && userpass.ContainsKey(userpassw))
                            {
                                Console.WriteLine("Incorrect Username");
                            }
                            else if (userlogin.ContainsKey(user) && !userpass.ContainsKey(userpassw))
                            {
                                Console.WriteLine("Incorrect Password");
                            }

                        }
                    }
                    
                } 

                else if (op1 == "3")
                {
                    Console.WriteLine("What User Type Are You?...1.Provider...2.User");
                    string op3= Console.ReadLine();
                    if (op3 == "1")
                    {
                        Console.WriteLine("Enter Username");
                        string providname = Console.ReadLine();
                        Console.WriteLine("Enter New Password");
                        string newpass= Console.ReadLine();

                        if (providelogin.ContainsKey(providname))
                        {
                            providelogin[providname] = newpass;
                            Console.WriteLine($"{providname} updated successfully");
                        }
                        else
                        {
                            Console.WriteLine($"{providname} does not exist");
                        }

                    }





                }
            }
        }
    }
}