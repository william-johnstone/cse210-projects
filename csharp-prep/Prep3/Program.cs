using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        Console.WriteLine($"The magic number is: {magicNumber}");
        Console.WriteLine($"The guess is: {guess}");
       
        while (guess != magicNumber)
        {
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
            }
        }

    }
}