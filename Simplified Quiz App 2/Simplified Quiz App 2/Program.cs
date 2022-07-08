namespace Simplified_Quiz_App_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> possible_word = new Dictionary<string, string>();

            List<QuizQuestion> quiz = new List<QuizQuestion>()
            {
                new QuizQuestion("how many days do we have in a week","3"," 4","6","7","D"),
                new QuizQuestion("what programming language are you learning now?","java"," javascript","c#","c++","C"),
                new QuizQuestion("who is the president of the united states?","joe biden", "buhari", "osibanjo", "david","A"),
                new QuizQuestion("which is the brain of the computer?","monitor","cpu","mouse","keyboard","B"),
                new QuizQuestion("which part of the computer is used to display information?","mouse","cpu","monitor","keyboard","C"),
            };

            int totalgrade = 0;

            foreach(var display in quiz)
            {

                AskQuestion(display);
                totalgrade += CheckAnswer(display.Answer);
            }

            Console.WriteLine($"Your Total Score Is : {totalgrade}");
            
            static void AskQuestion(QuizQuestion question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine($"(A) { question.OptionA}");
                Console.WriteLine($"(B){question.OptionB}");
                Console.WriteLine($"(C) {question.OptionC}");
                Console.WriteLine($"(D) {question.OptionD}");
                Console.WriteLine($"Enter Option :");
            }
            static int CheckAnswer(string correctanswer)
            {
                string answer = Console.ReadLine();

                if (answer.Equals(correctanswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"PASS,You've Scored 1 Point");
                    return 1;
                }
                else
                {
                    Console.WriteLine($"FAILED");
                    return 0;
                }

            }

        }
    }
}