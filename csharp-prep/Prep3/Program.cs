using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
// generate a random number from 1 to 100.
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;

            Console.WriteLine("Enter your guess:");
            int guess = int.Parse(Console.ReadLine());
// Keep track of how many guesses the user has made and inform them of it at the end of the game.
            guessCount++;

// Add a loop that keeps looping as long as the guess does not match the magic number.
            while (true)
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
                    break;
                }
            }
// Show the user how many guesses it took.
            Console.WriteLine($"You made {guessCount} guesses.");

// After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainInput = Console.ReadLine();

            if (playAgainInput.ToLower() != "yes")
            {
                break;
            }
        }
    }
}