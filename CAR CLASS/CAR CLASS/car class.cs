using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR_CLASS
{
    internal class car_class
    {
        public string name;
        public string brand;
        public int top_speed;
        public double tire_size;
        public string colors;

        public car_class (string name, string brand, int top_speed, double tire_size, string color)
        {
            name = name;
            brand = brand;
            top_speed = top_speed;
            tire_size = tire_size;
            color = colors;
        }
        public car_class()
        {
            
        }

    }
   


}
