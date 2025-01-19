using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {
            PlayGame();
            Console.WriteLine("Do you want to play again? (Yes/No)");
            string response = Console.ReadLine();
            if (response != "Yes")
            {
                playAgain = false;
            }
        }
    }

    static void PlayGame()
    {

        Random rand = new Random();
        int magicNumber = rand.Next(1, 101);

        int attempts = 0;

        bool correct = false;

        while (!correct)
        {
            attempts++;
            Console.WriteLine("What is your guess? ");
            string g = Console.ReadLine();
            int guess = int.Parse(g);

            if (guess == magicNumber)
            {
                Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                correct = true;
            }
            else if(guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if(guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}