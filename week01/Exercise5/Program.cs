using System;

class Program
{
    static void Main (string[] args)
    {
    
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();


        Console.WriteLine("Please enter your favorite number:");
        int favoriteNumber = int.Parse(Console.ReadLine());


        int squareNumber = (favoriteNumber * favoriteNumber);


        DisplayMessage();
        DisplayPersonalMessage(userName);
        DisplayPersonalNumber(favoriteNumber);
        DisplaySquareNumber(squareNumber, userName);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome the program!");
    }

    static void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine($"Please enter your name: {userName}");
    }

    static void DisplayPersonalNumber(int favoriteNumber)
    {
        Console.WriteLine($"Please enter your favorite number: {favoriteNumber}");
    }

    static void DisplaySquareNumber(int squareNumber, string userName)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }

}
