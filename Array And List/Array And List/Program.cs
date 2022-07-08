/*
string[] names = { "elon musk", "spacex", "tesla" };

Console.WriteLine(names[0]);
names[0] = "jeff bezors";

foreach (string i in names)
{
    Console.WriteLine(i);
}*/
//for list

List<string> cars = new List<string>();
//to add to list
cars.Add("tesla");
cars.Add("ford");
cars.Add("benz");
cars.Add("toyota");


foreach(string a in cars)
{
    if (a == "tesla")
    {
        Console.WriteLine("johns favourite car is a "+ cars[0]);
    }
    if (a == "ford")
    {
        Console.WriteLine("abigail favourite car is a " + cars[1]);
    }
    if (a == "benz")
    {
        Console.WriteLine("benz favourite car is a " + cars[2]);
    }
    if (a == "toyota")
    {
        Console.WriteLine("shedrack favourite car is a " + cars[3]);
    }






}

