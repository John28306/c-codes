namespace StaticModifier
{
    class program
    {
        static void Main(String[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine(Car.no_of_cars);
        }
    }
}