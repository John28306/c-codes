while(true)
{ 

Console.WriteLine("what would you like to do:SAVE,VIEW,UPDATE,DELETE");


string number;
    string name;
    string op;
    op= Console.ReadLine();
    string SAVE = Console.ReadLine();


    for (op = "SAVE")  
{
    Console.WriteLine("Enter Contact Name");
    name = Console.ReadLine();
    Console.WriteLine("Enter Contact number");
    number = Console.ReadLine();
    Console.WriteLine("Contact" + number+ "saved successfully");
}
}






//else if (int.Parse(num1) == 0)
//{
//    Console.WriteLine("the number you entered is 0");
//}
//else if (int.Parse(num1) == 1)
//{
//    Console.WriteLine("the number you entered is 1");
//}
//else if (int.Parse(num1) == 2)
//{
//    Console.WriteLine("the number you entered is 2");

//}
//else
//{
//    Console.Write("The number you entered is less than 10");
//}


//for save

//string SAVE = Console.ReadLine();



















//for view

//string VIEW = Console.ReadLine();
//Console.WriteLine("Enter Contact Name");
//Console.ReadLine();

//Dictionary<string, string> view = new Dictionary<string, string>();
//view.Add("john", "08110242445");









//Console.WriteLine("what would you like to do:SAVE,VIEW,UPDATE,DELETE");
