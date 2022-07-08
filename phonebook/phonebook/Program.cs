Dictionary<string, string> phonebook = new Dictionary<string, string>();

Console.Write("what would you like to do?...SAVE,VIEW,UPDATE,DELETE");

string op = Console.ReadLine();
if (op == "SAVE")
{
    Console.WriteLine("You Entered Save");