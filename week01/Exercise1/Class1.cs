namespace Exercise1
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Exercise1 Project..");

            Console.WriteLine("What is your first name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            var last_name = Console.ReadLine();

            Console.WriteLine($"Your name is {last_name}, {name} {last_name}.");
        }
    }
}