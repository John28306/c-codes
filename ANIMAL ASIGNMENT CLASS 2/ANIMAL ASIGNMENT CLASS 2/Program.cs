namespace ANIMAL_ASSIGNMENT_CLASS_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Animal_class> Question = new List<Animal_class>()
            {
               new Animal_class("giraffe","Giraffa camelopardalis","Herbivorous",true,"internal","sexually",false),
               new Animal_class("Antelope","Antilope cervicapra cervicapra","Herbivorous",true,"internal","sexually",true),
            };

            foreach (var ques in Question)
            {
                Console.WriteLine(ques.name);
            }
            Console.WriteLine("john");

        }
    }
}



