using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambleCorrection
{
    internal class Scramble
    {
        public string Question;
        public string Possible1;
        public string All;

        public Scramble (string quest, string optA, string all)
        {
            Question = quest;
            Possible1 = optA;
            All = all;

        }
    }
}
