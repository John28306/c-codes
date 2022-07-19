using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Set_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> level2 = new List<string>() { "Damian", "Martins", "Tushnie", "Blessing","John" };
            List<string> level3 = new List<string>() { "John", "Joe", "Daniel", "Alex" };

            //For Distinct

            //using method syntax
            var methodsyntax = level2.Distinct().ToList();
            //using query syntax
            var querysyntax = (from l in level2
                               select l).Distinct().ToList();

            //For Except

            //using method syntax
            var ms = level2.Except(level3).ToList();
            //using query syntax
            var qs = (from l in level2
                      select l).Except(level3).ToList();

            //For Intersect

            //using method syntax
            var methods = level2.Intersect(level3).ToList();
            //using query syntax
            var querys = (from l in level2
                          select l).Intersect(level3).ToList();
            //For Union

            //using method syntax
            var msyntax = level2.Union(level3).ToList();
            //using query syntax
            var qsyntax = (from l in level2
                           select l).Union(level3).ToList();
            Console.ReadLine();
        }
    }
}
