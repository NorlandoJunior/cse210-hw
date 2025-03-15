using System;

namespace team_activity
{
    class Program
    {
        static void Main()
        {
            Journal journal = new Journal();
            string fileName = "journal.txt";

            while (true)
            {
                Console.WriteLine("\nJournal Program");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display all entries");
                Console.WriteLine("3. Save journal to file");
                Console.WriteLine("4. Load journal from file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.AddEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile(fileName);
                        break;
                    case "4":
                        journal.LoadFromFile(fileName);
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
