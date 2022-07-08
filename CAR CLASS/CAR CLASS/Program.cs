//name = name;
//brand = brand;
//top_speed = top_speed;
//tire_size = tire_size;
//color = color;
namespace CAR_CLASS
{
    class program
    {
        static void Main (string [] arg)
        {
            car_class car1 = new car_class();
            car1.name = "Cyber_truck";
            car1.brand = "Tesla";
            car1.top_speed = 110;
            car1.tire_size = 35.0;
            car1.colors = "matte black";

            car_class car2 = new car_class("model 3", "Tesla", 160, 26.3, "Silver");
           

        }
    }
}
