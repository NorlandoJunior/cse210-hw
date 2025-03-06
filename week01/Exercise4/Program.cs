using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
                break;

            numbers.Add(num);
        }

        int sumNumbers = numbers.Sum();
        double average = numbers.Count > 0 ? numbers.Average() : 0;
        int largest = numbers.Max();
        var positiveNumbers = numbers.Where(n => n > 0).ToList();
        int smallestPositive = positiveNumbers.Count > 0 ? positiveNumbers.Min() : 0;
        numbers.Sort();  // Corrigido: Sort() com letra maiúscula

        // Correção: Usar WriteLine para melhor formatação da saída
        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");

        // Correção: Removido o ponto e vírgula no foreach
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
