using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Put your grade here: ");
        string answer = Console.ReadLine();
        
        
        double percent = double.Parse(answer);
        
        
        string letter = "";

        if (percent >= 95.7)
        {
            letter = "A+";
        }
        else if (percent >= 95)
        {
            letter = "A";
        }
        else if (percent >= 90.7)
        {
            letter = "A-";
        }
        else if (percent >= 85.7)
        {
            letter = "B+";
        }
        else if (percent >= 85)
        {
            letter = "B";
        }
        else if (percent >= 80.7)
        {
            letter = "B-";
        }
        else if (percent >= 75.7)
        {
            letter = "C+";
        }
        else if (percent >= 75)
        {
            letter = "C";
        }
        else if (percent >= 70.7)
        {
            letter = "C-";
        }
        else if (percent >= 65.7)
        {
            letter = "D+";
        }
        else if (percent >= 65)
        {
            letter = "D";
        }
        else if (percent >= 60.7)
        {
            letter = "D-";
        }
        else if (percent >= 60)
        {
            letter = "F+";
        }
        else if (percent <= 55.7)
        {
            letter = "F";
        }
        else if (percent <= 50)
        {
            letter = "F-";
        }

        
        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You pass! 🎉");
        }
        else
        {
            Console.WriteLine("You did not pass! 😭");
        }
    }
}
