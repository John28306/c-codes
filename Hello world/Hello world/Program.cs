// See https://aka.ms/new-console-template for more information
/*console.writeline is used to display text*/
/*note to always add a semi colon after every line of code on c sharp*/
Console.WriteLine("ogbu john");
Console.WriteLine(70 +5);
//to use a variable,input the variable type,the variable name = value;

//strings are used to store text of any length,a double quote is used
string myname ="ogbu john";
//to display the string
Console.WriteLine(myname);

//int are used to store integers/whole numbers of any length.
int age = 16;
//to display the int
Console.WriteLine(age);

//double are used to store floating point numbers/decimal point numbers
double height = 6;
//to display the double
Console.WriteLine(height);

//char are used to store single characters
char initials = 'O';
//to display the char
Console.WriteLine(initials);

//bool are used to store value with two state (true/false).
bool male = true;
//to display the bool
Console.WriteLine(male);
//to declare a variable and assign a value to it later.
int num;
num = 4;
Console.WriteLine(num);

//string concatenation
Console.WriteLine("hello i am " + myname + " i am " + age + " years old i am " + height + " feet tall the initials of my name is " + initials + " and it is " + male + " that am a male");
//for string interpolation
Console.WriteLine($"hello i am {myname} and i am {age} years old i am {height} feet tall the initials of of my name is {initials} and it is {male} that i am a male.");

// converting value types

//to convert string to int
string name = "5";
int number = 10;
Console.WriteLine(int.Parse(name) + number);

//to convert from int to string
Console.WriteLine(number.ToString()+name);

//for user input
string userinput;
userinput = Console.ReadLine();
Console.Write("the user entered;"+userinput);

//simple calculator project
Console.WriteLine("enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("enter second number");
string num2 = Console.ReadLine();
int total = int.Parse(num1) + int.Parse(num2);
Console.WriteLine("the answer is " + total);

Console.WriteLine($"the answer is {int.Parse(num1) + int.Parse(num2)}");
//for 
Console.WriteLine("enter first number");
