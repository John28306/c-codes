namespace Library_Project
{
    class program
    {
        static void Main(String[] args)
        {



            Dictionary<string, string> books = new Dictionary<string, string>();
            books.Add("1", "An Old Fashioned Girl");
            books.Add("2", "Beautiful GirlHood ");
            books.Add("3", "The Family Daughter");
            books.Add("4", "Let Me Be A Woman");
            books.Add("5", "Joyfully At Home");
            books.Add("6", "Raising Maidens Of Virtue");
            books.Add("7", "Stepping Heavenward");
            while (true)
            {
                Console.WriteLine("what would you want to do?...Borrow,Return");
                string op = Console.ReadLine();



                if (op == "borrow")
                {
                    Console.WriteLine("You Clicked Borrow ");

                    Console.WriteLine("All Available Books Are....");

                    foreach (var display in books)
                    {
                        Console.WriteLine(display);
                    }
                    Console.WriteLine("What Book Would You Want To Borrow");
                    string answer = Console.ReadLine();

                    if (books.ContainsKey(answer))
                    {
                        Console.WriteLine($"{books[answer]} Is Successfully Borrowed Out");
                        books.Remove(answer);
                    }
                  
                   
                    else if (books.Count == 0)
                    {
                        Console.WriteLine("There Is No Availiable Book Please Come Back Later");
                    }
                    foreach (var display in books)
                    {
                        Console.WriteLine(display);
                    }
                }
                else if (op == "return")
                {
                    Console.WriteLine("You Clicked Return");
                    Console.WriteLine("How Many Days Did You Keep The Book");
                    string days = Console.ReadLine();
                    if (int.Parse(days) <= 10)
                    {
                        //Console.WriteLine("Enter the Number On The First Page Of The Book You Want To Return");
                        //string book = Console.ReadLine();

                        //if (books.ContainsKey(book))
                        //{
                        //    Console.WriteLine($"{books[book]} Is Successfully Returned");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("PLease Enter A Valid Number");
                        //}
                    }
                    else if (int.Parse(days) > 10 && int.Parse(days) <= 30)
                    {

                        //Console.WriteLine("Enter the Number On The First Page Of The Book You Want To Return");
                        //string book = Console.ReadLine();
                        int fine = int.Parse(days) - 10;
                        //if (books.ContainsKey(book))
                        //{
                        //    Console.WriteLine($"{books[book]} Is Successfully Returned");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("PLease Enter A Valid Number");
                        //}
                        Console.WriteLine($"A Fine Of {fine * 50} Is To be Paid For Late Return Of Book ");
                    }
                    else if (int.Parse(days) > 30)
                    {

                        //Console.WriteLine("Enter the Number On The First Page Of The Book You Want To Return");
                        //string book = Console.ReadLine();
                        //if (books.ContainsKey(book))
                        //{
                        //    Console.WriteLine($"{books[book]} Is Successfully Returned");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("PLease Enter A Valid Number");
                        //}
                        int fine = int.Parse(days) - 10;
                        Console.WriteLine($"A Fine Of {fine * 100} Is To be Paid For Late Return Of Book ");
                    }
                }
                else
                {
                    Console.WriteLine("Enter A Valid Option");
                }
              }
        }
    }
}

