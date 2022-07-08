Console.WriteLine("CBT APP");
int total = 0;

Dictionary<string, int> login = new Dictionary<string, int>();
login.Add("123", 123);
login.Add("456", 456);
login.Add("789", 789);
login.Add("147", 147);
login.Add("258", 258);
int attemptleft = 5;

while (true)
{
    Console.WriteLine("Please Enter Your Registration Number");

    for (int i =1; i <= 5; i++)
    {
        string reg = Console.ReadLine();
          if (login.ContainsKey(reg))
             {
            Console.WriteLine("YOU HAVE SUCCESSFULLY LOGGED IN");


            QUESTION(" QUESTION 1: how many days do we have in a week", "(a)3", "(b)4", "(c)6", "(d)7");
            string op1 = Console.ReadLine();
            if (op1 == "d")
            {
                Console.WriteLine("Answer is correct");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
            QUESTION(" QUESTION 2: what programming language are you learning now?", "(a)java", "(b)javascript", "(c)c#", "(d)c++");
            string op2 = Console.ReadLine();
            if (op2 == "c")
            {
                Console.WriteLine("Answer is correct");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }

            QUESTION(" QUESTION 3: who is the president of the united states?", "(a)joe biden", "(b)buhari", "(c)osibanjo", "(d)david");
            string op3 = Console.ReadLine();
            if (op3 == "a")
            {
                Console.WriteLine("Answer is correct");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }

            QUESTION(" QUESTION 4: which is the brain of the computer?", "(a)monitor", "(b)cpu", "(c)mouse", "(d)keyboard");
            string op4 = Console.ReadLine();
            if (op4 == "b")
            {
                Console.WriteLine("Answer is correct");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }

            QUESTION(" QUESTION 5: which part of the computer is used to display information?", "(a)mouse", "(b)cpu", "(c) monitor", "(d)keyboard");
            string op5 = Console.ReadLine();
            if (op5 == "c")
            {
                Console.WriteLine("Answer is correct");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }

            Console.WriteLine($"Your Total Score Is {total++ * 2}");
            break;
        }

        else
        {
            Console.WriteLine($"INVALID LOGIN DETAILS");
            Console.WriteLine($"You Have {attemptleft = attemptleft - 1} Attempt Left");

        }
        if (!login.ContainsKey(reg) && i >= 5)
        {
            Console.WriteLine("ACCOUNT TEMPORARILY SUSPENDED");
        }
    }

    break;
}

static void QUESTION(string question, string option1, string option2, string option3, string option4)
{
    Console.WriteLine($"{ question},{ option1},{ option2},{ option3},{ option4}");

}