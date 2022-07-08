Dictionary<string, string> phonebook = new Dictionary<string, string>();
while (true)
{
    Console.WriteLine("what would u like to do save, view, update, delete");
    string op = Console.ReadLine();

    if (op == "save")
    {
        Console.WriteLine("u entered save");
        Console.WriteLine("enter contact name");
        string name = Console.ReadLine();

        Console.WriteLine("enter contact number");
        string number = Console.ReadLine();

        phonebook.Add(name, number);
        Console.WriteLine("" + name + " sucessfully saved");
    }


    else if (op == "view")
    {

        Console.WriteLine("u entered view");
        Console.WriteLine("enter contact name to view");
        string contactname = Console.ReadLine();
        if (phonebook.ContainsKey(contactname))
        {
            Console.WriteLine(phonebook[contactname]);
        }
        else
        {
            Console.WriteLine("contact does not exist");
        }

    }


    else if (op == "update")
    {
        Console.WriteLine("u entered update");
        Console.WriteLine("enter contact name to update");
        string name = Console.ReadLine();
        Console.WriteLine("enter new number  to update");
        string number = Console.ReadLine();
        phonebook[name] = number;
        Console.WriteLine(phonebook[name]);
        Console.WriteLine("number updated sucessfully");


        
    }

    else if (op == "delete")
    {
        Console.WriteLine("u entered delete");
        Console.WriteLine("enter contact name to delete");
        string name = Console.ReadLine();
        phonebook.Remove(name);
        Console.WriteLine("number deleted sucessfully");
    }

    else
    {
        Console.WriteLine("invalid command");
    }
}