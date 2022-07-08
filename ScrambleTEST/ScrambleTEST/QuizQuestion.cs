using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambleTEST
{
    internal class QuizQuestion
    {
            public string scrambled_word;
            public string Word1;
            public string Word2;
            public string Word3;
            public string Word4;
            public string All;


            public QuizQuestion(string scramb, string W1, string W2, string W3, string W4, string all)
            {

                scrambled_word = scramb;
                Word1 = W1;
                Word2 = W2;
                Word3 = W3;
                Word4 = W4;
                All = all;


            }

            public QuizQuestion()
            {

            }
        }
}
