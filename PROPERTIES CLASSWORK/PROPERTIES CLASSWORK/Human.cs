using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPERTIES_CLASSWORK
{
    internal class Human
    {

        
        private int Eye;
        private int Leg;
        private int Teeth;
        public string Color;


        public int EyeProperty
        {
            get { return Eye; }

            set
            {
                if (value != 2)
                {
                    Eye = 2;
                }
                else
                {
                    Eye = value;
                }
            }
        } 
                public int LegProperty
             {
                 get { return Leg; }
            set
            {
                if (value != 2)
                {
                    Leg = 2;
                }
                else
                {
                    Leg = value;
                }
            }
        }

             public int TeethProperty
             {
                 get { return Teeth; }
            set
            {
                if (value > 32)
                {
                    Teeth = 32;
                }
                else
                {
                    Teeth = value;
                }
            }
        }

             public string color { get; set; }

    }

}

