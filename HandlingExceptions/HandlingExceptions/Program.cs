
try
{
    Console.WriteLine("enter first number");
    string num1 = Console.ReadLine();

    Console.WriteLine("enter second number");
    string num2 = Console.ReadLine();
    Console.WriteLine("for divide");

    Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));

}
catch (FormatException)
{
    Console.WriteLine("enter only numbers please");
}
catch (DivideByZeroException)
{
    Console.WriteLine("You Cannot Divide By Zero");
}
catch (Exception err)
{
    Console.WriteLine(err);
}
finally
{
    Console.WriteLine("Thank You");
}
