using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess;
        int guessCount = 0;
        string guessDirection;

        Console.WriteLine("Guess My Number Game");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");
        Console.WriteLine();

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess < magicNumber)
            {
                guessDirection = "Higher";
            }
            else if (guess > magicNumber)
            {
                guessDirection = "Lower";
            }
            else
            {
                guessDirection = "You guessed it!";
            }

            Console.WriteLine(guessDirection);
            Console.WriteLine();

        } while (guess != magicNumber);

        Console.WriteLine($"It took you {guessCount} guesses to get the number.");
        Console.WriteLine();
        Console.Write("Do you want to play again? (yes or no) ");
        string playAgain = Console.ReadLine();

        while (playAgain == "yes")
        {
            magicNumber = random.Next(1, 101);
            guessCount = 0;

            Console.WriteLine("Guess My Number Game");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine();

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    guessDirection = "Higher";
                }
                else if (guess > magicNumber)
                {
                    guessDirection = "Lower";
                }
                else
                {
                    guessDirection = "You guessed it!";
                }

                Console.WriteLine(guessDirection);
                Console.WriteLine();

            } while (guess != magicNumber);

            Console.WriteLine($"It took you {guessCount} guesses to get the number.");
            Console.WriteLine();
            Console.Write("Do you want to play again? (yes or no) ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
