// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("+");
string num2 = Console.ReadLine();
int total1 = int.Parse(num1) + int.Parse(num2);
Console.WriteLine(int.Parse(num1) + int.Parse(num2));


Console.WriteLine("*");
string num3 = Console.ReadLine();
Console.WriteLine(total1 * int.Parse(num3));

int total2 = total1 * int.Parse(num3);
Console.WriteLine("-");
string num4 = Console.ReadLine();
Console.WriteLine(total2 - int.Parse(num4));

int total3 = total2 - int.Parse(num4);
Console.WriteLine("/");
string num5= Console.ReadLine();
Console.WriteLine(total3 / int.Parse(num5));





