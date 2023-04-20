using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();
        int smallestPositive = positiveNumbers.OrderBy(n => n).First();

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();

        Console.WriteLine("The sorted list is:");
        foreach (int n in sortedNumbers)
        {
            Console.WriteLine(n);
        }
    }
}