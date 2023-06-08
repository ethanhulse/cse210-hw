using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Activities");
        Console.WriteLine("---------------------");

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0)
            {
                break;
            }
            else if (choice == 1)
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());

                BreathingActivity breathingActivity = new BreathingActivity(duration);
                breathingActivity.Start();
            }
            else if (choice == 2)
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());

                ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
                reflectionActivity.Start();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());

                ListingActivity listingActivity = new ListingActivity(duration);
                listingActivity.Start();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine();
        }
    }
}
