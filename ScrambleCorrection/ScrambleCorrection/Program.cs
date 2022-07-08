namespace ScrambleCorrection
{
    class Program
    {
        static void Main(String[] args)
        {
            List<Scramble> questions = new List<Scramble>();
            {
                questions.Add(new Scramble("MROOFTISC", "SOFT", "SOFT"));
                questions.Add(new Scramble("MROOFTISC", "SOFT", "SOFT"));
                questions.Add(new Scramble("MROOFTISC", "SOFT", "SOFT"));
            }

            int totalgrade = 0;
            foreach (var check in questions)
            {
                Askquestion(check);
                PossibleWords((check.Possible1), (check.All));
            }
        

            //string attempt;
            
            static void Askquestion(Scramble question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine("Enter option: ");
            }

            static int PossibleWords(string test, string test2)
            {
                string answer = Console.ReadLine();

                if (answer.Equals(test, StringComparison.InvariantCultureIgnoreCase)) || (test2, StringComparison.InvariantCultureIgnoreCase))
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