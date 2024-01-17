using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;

            Console.WriteLine("Enter your guess:");
            int guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                Console.WriteLine("Enter your guess:");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessedCorrectly = true;
                }
            }

            Console.WriteLine($"You made {guessCount} guesses.");

            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainInput = Console.ReadLine();

            playAgain = (playAgainInput.ToLower() == "yes");
        }
    }
}