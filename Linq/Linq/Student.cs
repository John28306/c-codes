using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public string _firstname { get; set; }
        public string _Surname { get; set; }
        public string _CurrentClass { get; set; }
        public double _ResultAverage { get; set; }

        public Student(string firstname,string surname,string currentclass, double resultAverage)
        {
            _firstname = firstname;
            _Surname = surname;
            _CurrentClass = currentclass;
            _ResultAverage = resultAverage;
        }
        public Student()
        {

        }


    }
}
