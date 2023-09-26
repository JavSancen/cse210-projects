using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random rdm = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int num;
        int guesses;
        string response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            num = rdm.Next(min, max + 1);

            while (guess != num)
            {
                Console.WriteLine($"Your guess should be between {min} and {max}: ");
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine($"Guess: {guess}");

                if (guess > num)
                {
                    Console.WriteLine($"{guess} is to high!");
                }
                else if (guess < num)
                {
                    Console.WriteLine($"{guess} is to low!");
                }
                guesses++;
            }
            Console.WriteLine($"The number is: {num}");
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Number of guesses: {guesses}");

            Console.WriteLine("Would you want to play again?: (Y/N)");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

        }
        Console.WriteLine("Thanks for playing!");
    }
}