using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_watch_2
{
    class program
    {
        static void Main(String [] args)
        {
            List<Employees> employees = new List<Employees>()
            {
                new Employees(){id=1,name="Tom", email="tom@gmail.com"},
                new Employees(){id=2,name="isaac", email="isaac@gmail.com"},
                new Employees(){id=3,name="alex", email="alex@gmail.com"},
                new Employees(){id=4,name="samuel", email="samuel@gmail.com"},
            };
            //var basicQuery = (from obj in employees
            //                  select obj).ToList();
            //var basicMethod = employees.ToList();

            //var  basicPropQuery= (from obj in employees
            //                      select obj.id).ToList();

            //var basicPropMethod = employees.Select(obj=>obj.id).ToList();

            //To Select Specific Data From The Class
            var selectQuery = (from obj in employees
                               select new Employees
                               {
                                   id=obj.id,
                                   name=obj.name

                               }).ToList();
            var selectMethod = employees.Select(obj => new Employees()
            {
                id = obj.id,
                name = obj.name
            }).ToList();

            //To Move Data Fom One Class To Another
            //i.e Class Employees To Class Student

            var selectvQuery = (from obj in employees
                               select new Student
                               {
                                   Studentid = obj.id,
                                   FullName = obj.name,
                                   STemails=obj.email

                               }).ToList();

            var selectvMethod = employees.Select(obj => new Student()
            {
                Studentid = obj.id,
                FullName = obj.name,
                STemails = obj.email
            }).ToList();

            //To Create Anonymous Class
            var selectyquery = (from obj in employees
                                select new
                                {
                                    CustomId = obj.id,
                                    CustomName = obj.name,
                                    CustomMails = obj.email
                                }).ToList();
            var selectyMethod = employees.Select(obj => new
            {
                CustomId = obj.id,
                CustomName = obj.name,
                CustomMails = obj.email
            }).ToList();

            //To Select Data By Index
            var method = employees.Select((obj, index) => new { Index = index, Fullname = obj.name}).ToList();

            foreach (var item in selectyMethod)
            {
                Console.WriteLine($"id = {item.CustomId}, Name= {item.CustomName}, Email= {item.CustomMails}");
            }


            //Using SelectMany
            List<string> list = new List<string>() { "ogbu", "John" };

            //Using Query syntax
            var selectQueryy = (from obj in list
                                from ch in obj
                                select ch).ToList();

            //Using Method syntax 
            var selectMethodd = list.SelectMany(x => x).ToList();
            var datasource = new List<Employees>()
            {
                new Employees(){id=1,name="tom",email="tom@gmail.com",programming=new List<string>(){"BTC","C#","C"}},
                new Employees(){id=2,name="Samuel",email="samuel@gmail.com",programming=new List<string>(){"LINQ","C#","SQL"}},
                new Employees(){id=3,name="Alex",email="alex@gmail.com",programming=new List<string>(){"BNB","C#","C"}},
                new Employees(){id=4,name="dan",email="dan@gmail.com",programming=new List<string>(){"PHP","SOL","C"}}
            };
            var methodSyntax = datasource.SelectMany(obj => obj.programming).ToList();

            foreach(var item in methodSyntax)
            {
                Console.WriteLine($"Programming is {item}");
            }


            Console.ReadLine();


        }
    }
}