using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Linq_test
{
    class program
    {
        static void Main(String[] args)
        {
            //1
            //where and oftype
            //2.
            //select and selectmany
            //3a
            List<object> test = new List<object>() { "daniel", "John", "Joe", 1, 2, 3, 4, 5 };
            //3b
            var ms = test.OfType<string>().ToList();
            //3c
            var ms2 = test.OfType<string>().Where(l => l.Length >= 5).ToList();
            //4
            //Sorting Operators help us sort or arrange our data in a particular order
            //thenby,thenby decending,orderby,orderby decending,reverse.
            //5
            List<int> sorting = new List<int>() { 5, 2, 3, 4, 1 };
            var method = sorting.OrderBy(it => it).ToList();
            var met = sorting.OrderByDescending(it => it).ToList();
            //6
            List<Days> daysofweek = new List<Days>()
            {
                new Days()
                {
                    Firstname="Ogbu",
                    Lastname="John",
                    Course="AAEES",
                    Level=300
                },
                 new Days()
                {
                    Firstname="Oklobia",
                    Lastname=" Daniel",
                    Course="EEE",
                    Level=300
                },
                  new Days()
                {
                    Firstname="Idoga",
                    Lastname=" Joseph",
                    Course="EEE",
                    Level=300
                },
            };
            var meth = daysofweek.OrderBy(b => b.Firstname).ThenBy(b => b.Lastname).ToList();

            foreach (var item in meth) 
            {
                Console.WriteLine($"my name is {item.Lastname} and {item.Firstname} a {item.Level} of {item.Course}");
            }
            //7
            int[] inte= new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var msy = inte.Reverse();
            foreach(var ten in msy)
            {
                Console.WriteLine(ten);
            }

            Console.ReadLine();
        }
    }
}
