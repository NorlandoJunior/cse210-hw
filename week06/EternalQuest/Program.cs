using EternalQuest;

class Program
{
    static void Main()
    {
        GoalManager gm = new();
        bool running = true;

        while (running)
        {
            Console.WriteLine($"\nScore: {gm.GetScore()}");
            Console.WriteLine("1. Create Goal\n2. Record Event\n3. Show Goals\n4. Save\n5. Load\n6. Quit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(gm);
                    break;
                case "2":
                    gm.ShowGoals();
                    Console.Write("Which goal? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    gm.RecordGoal(index);
                    break;
                case "3":
                    gm.ShowGoals();
                    break;
                case "4":
                    gm.Save("goals.txt");5
                    break;
                case "5":
                    gm.Load("goals.txt");
                    break;
                case "6":
                    running = false;
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager gm)
    {
        Console.WriteLine("Select type: 1) Simple 2) Eternal 3) Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        Goal goal = type switch
        {
            "1" => new SimpleGoal(name, desc, pts),
            "2" => new EternalGoal(name, desc, pts),
            "3" => CreateChecklistGoal(name, desc, pts),
            _ => null
        };

        if (goal != null)
        {
            gm.AddGoal(goal);
            Console.WriteLine("Goal added!");
        }
    }

    static Goal CreateChecklistGoal(string name, string desc, int pts)
    {
        Console.Write("How many times to complete it? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Bonus points on completion: ");
        int bonus = int.Parse(Console.ReadLine());
        return new ChecklistGoal(name, desc, pts, target, bonus);
    }
}
