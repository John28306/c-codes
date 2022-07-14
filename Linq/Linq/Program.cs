using System;
using System.Collections.Generic;
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
            var querySyntax = from obj in student
                              where obj._CurrentClass == "100" && obj._ResultAverage>= 50
                              //where obj._ResultAverage >= 50
                              select obj;
            foreach (var all in querySyntax)
            {
                Console.WriteLine($"{all._Surname}  {all._firstname} {all._CurrentClass} {all._ResultAverage} ");
            }
            Console.WriteLine("----------------------------");

            var methodSyntax = student.Where(obj => obj._CurrentClass == "100" && obj._ResultAverage >=50);


            foreach (var all in methodSyntax)
            {
                Console.WriteLine($"{all._Surname}  {all._firstname} {all._CurrentClass} {all._ResultAverage}");

            }
            Console.WriteLine("----------------------------");


            var mixedSyntax = (from obj in student
                               select obj._ResultAverage).Max();

            Console.WriteLine($" Total Max= {mixedSyntax}");







        }
    }
}