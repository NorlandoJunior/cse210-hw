using System;

class Program {

public static void Main(string[] args)
{



    Random randomGeneretor = new Random();
    int magicNumber = randomGeneretor.Next(1, 101);

    int guess = -1;
    
    // diferent the magic number reapeat/loop
    
    while (guess != magicNumber)
    
    { 

     Console.WriteLine("What is your guess?");
     string answer = Console.ReadLine();

     guess = int.Parse(answer);
    
     if (magicNumber > guess)
     {
        Console.WriteLine("Higer!");
     }
     else if (magicNumber < guess)
     {
        Console.WriteLine("Lower!");
     }
     else
     {
        Console.WriteLine("You guessed it!");
     }
    }
}
}


