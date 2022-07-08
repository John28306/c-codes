//static int Squareroot(int num1)
//{
//    return num1 * num1;
//}

//Console.WriteLine((Squareroot(10)));
//static int cube(int num1)
//{
//    return num1 * num1 * num1;
//}
//Console.WriteLine((cube(10)));



static void sentence()
{

    Console.WriteLine($"Today is {DateTime.Now.ToString("dddddd")} the {DateTime.Now.ToString("dd")} of {DateTime.Now.ToString("MMMM")} and the time is {DateTime.Now.ToString("h:mm:ss tt")} in the the year {DateTime.Now.Date.ToString("yyyy")}");
}

sentence();

