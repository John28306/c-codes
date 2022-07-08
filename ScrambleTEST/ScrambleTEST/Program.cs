
Dictionary<string, string> possible_word = new Dictionary<string, string>();



namespace ScrambleTEST
{
    class Program
    {

        static void Main(string[] args)
        {
            //Dictionary<string, string> possible_word = new Dictionary<string, string>();

            List<QuizQuestion> quiz = new List<QuizQuestion>()
            {
                new QuizQuestion("uestionq","stine","us","on","to","stine,us,on,to"),
              
            };

            //int totalgrade = 0;

            foreach (var display in quiz)
            {
                Console.WriteLine("hello");
                //AskQuestion(display);
                //CheckAnswer(display.All);
            }

            ////Console.WriteLine($"Your Total Score Is : {totalgrade}");

            //static void AskQuestion(QuizQuestion question)
            //{
            //    Console.WriteLine(question.scrambled_word);

            //    Console.WriteLine($"Enter Option :");
            //}
            //static int CheckAnswer(string correctanswer)
            //{

            //    string[] possibleword = { "type", "typewriter", "writer", "pot", "we", "wet" };

            //    //List<string> possiblewords = new List<string>();
            //    //possiblewords.Add(possibleword);


            //    string answer = Console.ReadLine();

            //    if (answer.Contains(correctanswer))
            //    {
            //        Console.WriteLine($"PASS,You've Scored 1 Point");
            //        return 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"FAILED");
            //        return 0;
            //    }


            //}

        }
    }
}