using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class program
    {
        static void Main(String[] args)
        {
            List<Student> student = new List<Student>()
            {
                new Student("Judith","Samuel","100",67.5),
                new Student("Joseph","Ajonye","500",50.0),
                new Student("Daniel","Oklobia","300",40.0),
                new Student("Alex","Onoja","300",87.3),
                new Student("Martin","Abah","200",59.5),
                new Student("Tushnie","Utakka","200",28.5),
                new Student("Elijah","Bala","300",35.5),
                new Student("Elijah","moses","100",30.5),

            };

            class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student? x, Student? y)
            {
                return x._Surname.Equals(y._Surname) && y._Surname.Equals(x._Surname);
            }

            public int GetHashCode([DisallowNull] Student obj)
            {
                int Gethashcode = obj._Surname.GetHashCode();
                int namehashcode = obj._firstname.GetHashCode();
            }
        }
        //var selectQuery = (from obj in student
        //                   select obj).ToList();

        //var methodSyntax = student.Select(obj => obj).ToList();

        var methodselect = student.SelectMany(x => x._firstname).ToList();

            //foreach (var item in methodselect)
            //{
            //    Console.WriteLine($"{ item._Surname} {item._firstname} {item._firstname} {item._ResultAverage}");
            //}

            Console.ReadLine();

            //var querySyntax = from obj in student
            //                  where obj._CurrentClass == "100" && obj._ResultAverage>= 50
            //                  //where obj._ResultAverage >= 50
            //                  select obj;
            //foreach (var all in querySyntax)
            //{
            //    Console.WriteLine($"{all._Surname}  {all._firstname} {all._CurrentClass} {all._ResultAverage} ");
            //}
            //Console.WriteLine("----------------------------");

            //var methodSyntax = student.Where(obj => obj._CurrentClass == "100" && obj._ResultAverage >=50);


            //foreach (var all in methodSyntax)
            //{
            //    Console.WriteLine($"{all._Surname}  {all._firstname} {all._CurrentClass} {all._ResultAverage}");

            //}
            //Console.WriteLine("----------------------------");


            //var mixedSyntax = (from obj in student
            //                   select obj._ResultAverage).Max();

            //Console.WriteLine($" Total Max= {mixedSyntax}");







        }
    }
}