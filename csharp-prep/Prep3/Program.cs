using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1;
        int countGuess = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        Console.WriteLine($"The magic number is: {magicNumber}");
        Console.WriteLine($"The guess is: {guess}");
       
        while (guess != magicNumber)
        {
            countGuess++;
            Console.Write($"What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"The magic number = {magicNumber}");
                Console.WriteLine("You got it!");
                Console.WriteLine($"You've guessed {countGuess} times!");
                Console.Write("Would you like to play again? y/n ");
                string again = Console.ReadLine();
                if (again == "y")
                {
                    magicNumber = randomGenerator.Next(1, 101);
                    guess = -1;
                }
            }
        }
    }
}