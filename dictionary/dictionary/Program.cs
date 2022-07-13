
//Dictionary<int, string> studentlist = new Dictionary<int, string>();

//studentlist.Add(1, "watching movies" );
//studentlist.Add(2, "listening to music");
//studentlist.Add(3, "reading");



//foreach (var a in studentlist)
//{
//    Console.WriteLine(1);
//}



        // a new dictionary is created with key type string and value type string
        Dictionary<int, string> hobby = new Dictionary<int, string>();
        // using add method in dictionary to add the objects to the dictionary
        hobby.Add(1,"Reading");
        hobby.Add(2, "Watching Movies");
        hobby.Add(3, "Listening To Music");




    Console.WriteLine("My Hobbies Are;");
foreach (var test in hobby)
{
    Console.WriteLine(test.Value);
}

for (int i = 1; i <= hobby.Count; i++)
{
    Console.WriteLine(hobby[i]);
}