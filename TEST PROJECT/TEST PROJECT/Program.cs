
Console.WriteLine("phonebook app");

Dictionary<string, string> data = new Dictionary<string, string>();

//while (true)
//{


    Console.WriteLine("What Would You Want To Do?,SAVE,VIEW,EDIT,DELETE");
    string opt = Console.ReadLine();
    if (opt == "save")
    {
        Console.WriteLine("You Selected Save");
        Console.WriteLine("Enter Name To Save");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Number To Save");
        string number = Console.ReadLine();
        data.Add(name, number);
    }
    else if(opt == "view")
{
    Console.WriteLine("You Selected view");
    Console.WriteLine("search......");
    string view = Console.ReadLine();
    if(data.ContainsKey(view))
    {
        Console.WriteLine();
    }

}









//}
