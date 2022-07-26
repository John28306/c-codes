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
            //OBJECTIVES BOLT FOR BIKE
            //provide signup
            //user signup
            //provide login
            //user login.

            List<User> user = new List<User>()
            {
                //new User("ogbu john", "harrison adoga avenue","john28306@gmail.com","John28306"),
                new User("", "","",""),
                new User("","","",""),
                new User("","","",""),
                new User("","","",""),
            };

            foreach (var display in user)
            {
                UserLogin(display);
                //totalgrade += CheckAnswer(display.Answer);
            }


            static void UserLogin(User question, string fullname,string address,string email,string password)
            {
                //Console.WriteLine(question.Question);
                Console.WriteLine($"Enter Fullname");
                fullname = Console.ReadLine();
                Console.WriteLine($"(Your address){question.Address=address}");
                Console.WriteLine($"(Your Email) {question.Email=email}");
                Console.WriteLine($"(Enter Password) {question.Password=password}");
                Console.WriteLine($"Enter Option :");
            }
            //static int CheckAnswer(string correctanswer)
            //{
            //    string answer = Console.ReadLine();

            //    if (answer.Equals(correctanswer, StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        Console.WriteLine($"PASS,You've Scored 1 Point");
            //        return 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"FAILED");
            //        return 0;
            //    }

            //}












































            //List<User> user = new List<User>()
            //{
            //};

            //List<Provider> provide = new List<Provider>()
            //{
            //};

            //Console.WriteLine("What would you want to do...1.Signup...2.Login...3.Forgot_Password");
            //string op=Console.ReadLine();
            //if (op == "1")
            //{
            //    Console.WriteLine("What category do you want to register under...1.User..2.Provider");
            //    string op1 = Console.ReadLine();
            //    if (op1 == "1")
            //    {
            //        Console.WriteLine("Kindly fill the form Below");
            //        Console.WriteLine("your Fullname");
            //        string fullname = Console.ReadLine();
            //        Console.WriteLine("your Email");
            //        string email = Console.ReadLine();
            //        Console.WriteLine("your Password");
            //        string password = Console.ReadLine();
            //        Console.WriteLine("your Address");
            //        string address = Console.ReadLine();
            //        new User(fullname,email,password,address);
            //        Console.WriteLine("Thank You for signing up");
            //    }
            //    else if (op1 == "2")
            //    {
            //        Console.WriteLine("Kindly fill the form Below");
            //        Console.WriteLine("your Fullname");
            //        string fullname = Console.ReadLine();
            //        Console.WriteLine("your Email");
            //        string email = Console.ReadLine();
            //        Console.WriteLine("your Password");
            //        string password = Console.ReadLine();
            //        Console.WriteLine("your Address");
            //        string address = Console.ReadLine();
            //        new User(fullname, email, password, address);
            //        Console.WriteLine("Thank You for signing up");
            //    }


        }
    }
}