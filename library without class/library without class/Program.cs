Dictionary<string, string> phonebook = new Dictionary<string, string>();


    Console.WriteLine("what would you want to do?...Borrow A Book,Return A Book");

    string op = Console.ReadLine();

    List<string> Books = new List<string>();
    Books.Add("An Old Fashioned Girl"); /*by Louisa May Alcott*/
    Books.Add("Beautiful GirlHood");/* by Unknown*/
    //Books.Add("The Family Daughter"); /*by Sarah L.Bryan,*/
    //Books.Add("Let Me Be A Woman "); /*by Elloit*/
    //Books.Add("Joyfully At Home "); /*by Baucham*/
    //Books.Add("Raising Maidens Of Virtue");/* by Mcdonald*/
    //Books.Add("Stepping Heavenward"); /*by Prentiss*/


    while (true)
    {

        if (op == "Borrow")
    {
       

       
        Console.WriteLine("You Entered Borrow");

        Console.WriteLine("All Availiable books are");
        foreach(var items in Books)
        {
            Console.WriteLine(items);
        }
        Console.WriteLine("Enter Name Of Book You Would Want ");
        string name = Console.ReadLine();
        if (Books.Contains(name))
        {
            Console.WriteLine($"you selected {name}");

        }
        else
        {
            Console.WriteLine($"Please Choose From Availiable List");

        }
      
            Books.Remove(name);
        Console.WriteLine("Updated List of Availiable books Is");


        foreach (var items in Books)
        {
            Console.WriteLine(items);
        }
            break;
        }
















    //    phonebook.Add(name, number);

    //    Console.WriteLine($"contact {name} sucessfully saved");

    //}
    //else if (op == "VIEW")
    //{
    //    Console.WriteLine("You Entered View");
    //    Console.WriteLine("Enter Contact Name To View");
    //    string name = Console.ReadLine();

    //    if (phonebook.ContainsKey(name))
    //    {
    //        Console.WriteLine($"The number is {phonebook[name]}");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{name} does not exist");

    //    }


    //}

    //else if (op == "UPDATE")
    //{
    //    Console.WriteLine("You Entered Update");
    //    Console.WriteLine("Enter Contact Name To Update");
    //    string name = Console.ReadLine();
    //    Console.WriteLine("Enter Contact number To Update");

    //    string newnum = Console.ReadLine();
    //    if (phonebook.ContainsKey(name))
    //    {
    //        phonebook[name] = newnum;
    //        Console.WriteLine($"{name} updated successfully");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{name} does not exist");
    //    }

    //}

    //else if (op == "DELETE")
    //{
    //    Console.WriteLine("You Entered Delete");
    //    Console.WriteLine("Enter Contact Name To Delete");
    //    string name = Console.ReadLine();

    //    if (phonebook.ContainsKey(name))
    //    {
    //        phonebook.Remove(name);
    //        Console.WriteLine($"{name} Deleted successfully");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{name} does not exist");
    //    }


    //}

    //else
    //{
    //    Console.WriteLine("Enter Valid Option");




}