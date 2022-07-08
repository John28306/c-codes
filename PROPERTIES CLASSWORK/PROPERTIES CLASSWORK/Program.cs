
namespace PROPERTIES_CLASSWORK
{
    class program
    {
        static void Main(String[] args)
        {
            Human john = new Human();

            john.EyeProperty = 1;
            john.LegProperty = 1;
            john.TeethProperty = 9;
            john.color = "Chocolate";

            Console.WriteLine(john.EyeProperty);
            Console.WriteLine(john.LegProperty);
            Console.WriteLine(john.TeethProperty);
            Console.WriteLine(john.color);

        }







    }
}
