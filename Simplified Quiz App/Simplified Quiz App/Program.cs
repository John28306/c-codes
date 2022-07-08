namespace Simplified_Quiz_App
{
    class Program
    {
        static void Main(string[] args)
        {
            QuizQuestion question1 = new QuizQuestion();
            question1.Question = "how many days do we have in a week";
            question1.OptionA = "3";
            question1.OptionB = " 4";
            question1.OptionC = "6";
            question1.OptionD = "7";
            question1.Answer = "D";

            QuizQuestion question2 = new QuizQuestion();
            question2.Question = "what programming language are you learning now?";
            question2.OptionA = "java";
            question2.OptionB = " javascript";
            question2.OptionC = "c#";
            question2.OptionD = "c++";
            question2.Answer = "C";


            Console.WriteLine(question2.OptionA);


        }
    }
}