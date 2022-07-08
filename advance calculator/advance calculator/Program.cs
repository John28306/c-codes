
while(true)
 {


    Console.WriteLine("enter a number");
string num1;
num1 = Console.ReadLine();
Console.WriteLine("choose an operator,there are +,-,*,/,%,^");

string op;
op = Console.ReadLine();




    Console.WriteLine("enter the second number");
    string num2;
    num2 = Console.ReadLine();
    if (op == "+")
    {
        Console.WriteLine(int.Parse(num1) + int.Parse(num2));
    }
    else if (op == "-")
    {
        Console.WriteLine(int.Parse(num1) - int.Parse(num2));
    }

    else if (op == "*")
    {
        Console.WriteLine(int.Parse(num1) * int.Parse(num2));
    }
    else if (op == "/")
    {
        Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
    }
    else if (op == "%")
    {
        Console.WriteLine(int.Parse(num1) % int.Parse(num2));
    }
    else if (op == "^")
    {
        Console.WriteLine(Math.Sqrt(int.Parse(num1) + int.Parse(num2)));
    }
    else
    {
        Console.WriteLine("select a valid operator");
    }
}