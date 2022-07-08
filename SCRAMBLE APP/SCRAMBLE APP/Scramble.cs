using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRAMBLED_APP_APP
{
    internal class Scramble
    {

        public string Question;
        public string Possible1;
        public string Possible2;
        //public string Possible3;
        //public string Possible4;
        public string All;


        public Scramble(string quest, string optA, string optB, string all)
        {
            Question = quest;
            Possible1 = optA;
            Possible2 = optB;
            //Possible3 = optC;
            //Possible4 = optD;
            All = all;


        }

        public Scramble()
        {

        }

    }
}