 namespace SCRAMBLED_APP_APP
{
    class Program
    {
        static void Main(String[] args)
        {
            Dictionary<string, string> Scramble = new Dictionary<string, string>();

            List<Scramble> questions = new List<Scramble>();
            {
                questions.Add(new Scramble("MROOFTISC", "MICROSOFT", "SOFT", "MICRO"));


            }
            int totalgrade = 0;                                                                                                                                                                                                                              
            foreach (var check in questions)
            {
                Askquestion(check);
               totalgrade += PossibleWords((check.Possible1), (check.Possible2), (check.All));
                totalgrade += PossibleWords((check.Possible1), (check.Possible2), (check.All));
                totalgrade += PossibleWords((check.Possible1), (check.Possible2), (check.All));
            }


            static void Askquestion(Scramble question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine("Enter option: ");
            }
            Console.WriteLine($"You Scored A Total Of {totalgrade} Point");

            static int PossibleWords(string test,string test2,string test3)
            {
                string answer = Console.ReadLine();

                if (answer.Equals(test, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(test2, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(test3, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"PASS,You've Scored 1 Point");
                    return 1;
                }
                else
                {
                    Console.WriteLine("failed");
                    return 0;
                }
            }

        }

    }
}
