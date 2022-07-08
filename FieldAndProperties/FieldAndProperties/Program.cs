namespace FieldAndProperties
{
    class program
    {
        static void Main( String[] args)
        {
            Car car1 = new Car();
            car1.SpeedProperty = 5000;
            car1.WheelsProperty = 5;
            car1.color = "steel";

            Console.WriteLine(car1.SpeedProperty);
            Console.WriteLine(car1.WheelsProperty);
            Console.WriteLine(car1.color);



        }
    }
}
