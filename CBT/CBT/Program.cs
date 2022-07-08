Console.WriteLine("CBT APP");
List<int> total = new List<int>();

while (true)
{
    Console.WriteLine(" QUESTION 1: how many days do we have in a week");

    List<string> ques1 = new List<string>();

    ques1.Add("(a)3");
    ques1.Add("(b)4");
    ques1.Add("(c)6");
    ques1.Add("(d)7");
    ques1.Add("Select any other options to skip question ");

    foreach (var test in ques1)
    {
        Console.WriteLine(test);
    }

    string op = Console.ReadLine();
    if (op == "d")
    {
        total.Add(5);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");

    }
    else if (op == "a" ||op== "b" ||op==  "c") 
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is d");
    }
   
    else
    {
        Console.WriteLine(" Skipped Question");

    }

    Console.WriteLine(" QUESTION 2: what programming language are you learning now?");
    List<string> ques2 = new List<string>();

    ques2.Add("(a)java");
    ques2.Add("(b)javascript");
    ques2.Add("(c)c#");
    ques2.Add("(d)c++");
    ques2.Add("Select  any other options to skip question ");

    foreach (var test in ques2)
    {
        Console.WriteLine(test);
    }

    string op2 = Console.ReadLine();
    if (op2 == "c")
    {
        total.Add(5);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");

    }

    else if (op == "a" || op == "b" || op == "d")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is c");
    }

    else
    {
        Console.WriteLine(" Skipped Question");

    }


    Console.WriteLine(" QUESTION 3: who is the president of the united states?");
List<string> ques3 = new List<string>();

ques3.Add("(a)joe biden");
ques3.Add("(b)buhari");
ques3.Add("(c)osibanjo");
ques3.Add("(d)david");
ques3.Add("Select  any other options to skip question ");

    foreach (var test in ques3)
{
    Console.WriteLine(test);
}

string op3 = Console.ReadLine();
if (op3 == "a")
{
        total.Add(5);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");
    }
    else if (op == "d" || op == "b" || op == "c")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else
    {
        Console.WriteLine(" Skipped Question");

    }


    Console.WriteLine(" QUESTION 4: which is the brain of the computer?");
    List<string> ques4 = new List<string>();

    ques4.Add("(a)monitor");
    ques4.Add("(b)cpu");
    ques4.Add("(c)mouse");
    ques4.Add("(d)keyboard");
    ques4.Add("Select  any other options to skip question ");

    foreach (var test in ques4)
    {
        Console.WriteLine(test);
    }


    string op4 = Console.ReadLine();
    if (op4 == "b")
    {
        total.Add(5);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");
    }
    else if (op == "a" || op == "d" || op == "c")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is b");
    }
    else
    {
        Console.WriteLine(" Skipped Question");

    }



    Console.WriteLine(" QUESTION 5: which part of the computer is used to display information?");
    List<string> ques5 = new List<string>();

    ques5.Add("(a)mouse");
    ques5.Add("(b)cpu");
    ques5.Add("(c)monitor");
    ques5.Add("(d)keyboard");
    ques5.Add("Select  any other options to skip question ");

    foreach (var test in ques5)
    {
        Console.WriteLine(test);
    }


    string op5 = Console.ReadLine();
    if (op5 == "c")
    {
        total.Add(5);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");
    }
    else if (op == "a" || op == "b" || op == "d")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is c");
    }

    else
    {
        Console.WriteLine(" Skipped Question");


    }

    Console.WriteLine($"Congratulation,your total score is {total.Sum()}");


    break;
}