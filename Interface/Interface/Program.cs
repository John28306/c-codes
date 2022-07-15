namespace Interface
{
    class program
    {
        static void Main(String[] args)
        {
            //datasource
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            
            //for querysyntax
            var querySyntax = from obj in list //initialiation
                              where obj == 2  //condition
                              select obj;   //selection
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            //for method syntax
            var methodSyntax = list.Where(obj => obj > 2);
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");

            var mixedSyntax = (from obj in list
                               select obj).Max();
            Console.WriteLine($"Max value = {+mixedSyntax} ");

            Console.ReadLine();
        }
    }
}