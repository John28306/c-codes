Dictionary<string, string> phonebook = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("what would you want to do?...SAVE,VIEW UPDATE,DELETE");

string op = Console.ReadLine();



    if (op == "SAVE")
    {
        Console.WriteLine("You Entered Save");
        Console.WriteLine("Enter Contact Number");
        string number = Console.ReadLine();
        Console.WriteLine("Enter Contact name");
        string name = Console.ReadLine();

        phonebook.Add(name, number);

        Console.WriteLine($"contact {name} sucessfully saved");

    }
    else if (op == "VIEW")
    {
        Console.WriteLine("You Entered View");
        Console.WriteLine("Enter Contact Name To View");
        string name = Console.ReadLine();

        if (phonebook.ContainsKey(name))
        {
            Console.WriteLine($"The number is {phonebook[name]}");
        }
        else
        {
            Console.WriteLine($"{name} does not exist");

        }


    }

    else if (op == "UPDATE")
    {
        Console.WriteLine("You Entered Update");
        Console.WriteLine("Enter Contact Name To Update");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Contact number To Update");

        string newnum = Console.ReadLine();
        if (phonebook.ContainsKey(name))
        {
            phonebook[name] = newnum;
            Console.WriteLine($"{name} updated successfully");
        }
        else
        {
            Console.WriteLine($"{name} does not exist");
        }
      
    }

    else if (op == "DELETE")
    {
        Console.WriteLine("You Entered Delete");
        Console.WriteLine("Enter Contact Name To Delete");
        string name = Console.ReadLine();

        if (phonebook.ContainsKey(name))
        {
            phonebook.Remove(name);
            Console.WriteLine($"{name} Deleted successfully");
        }
        else
        {
            Console.WriteLine($"{name} does not exist");
        }

        
    }

    else
    {
        Console.WriteLine("Enter Valid Option");

    }
}