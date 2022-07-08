using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMAL_ASIGNMENT_CLASS_2
{


    internal class Animal
    {
        public string _name { get; set; }
        public string scientific_name { get; set; }
        public string mode_of_feeding { get; set; }
        public bool movement { get; set; }
        public string mode_of_respiration { get; set; }
        public string mode_of_reproduction { get; set; }
        public bool _horn { get; set; }

        public Animal(string name, string sciencename, string feed, bool move, string resp, string rep, bool horn)
        {
            _name = name;
            scientific_name = sciencename;
            mode_of_feeding = feed;
            movement = move;
            mode_of_respiration = resp;
            mode_of_reproduction = rep;
            _horn = horn;
        }
        public Animal()
        {

        }

    }



}
