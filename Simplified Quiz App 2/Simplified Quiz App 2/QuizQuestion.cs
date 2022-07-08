using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_Quiz_App_2
{
    internal class QuizQuestion
    {

        public string Question;
        public string OptionA;
        public string OptionB;
        public string OptionC;
        public string OptionD;
        public string Answer;


        public QuizQuestion(string ques, string Op1, string Op2, string Op3, string Op4, string Ans)
        {
            Question = ques;
            OptionA = Op1;
            OptionB = Op2;
            OptionC = Op3;
            OptionD = Op4;
            Answer = Ans;
            
        }

        public QuizQuestion()
        {

        }
    }

       

}

