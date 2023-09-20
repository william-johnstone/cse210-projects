using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<decimal> numbers = new List<decimal>();
        decimal input = -1;
        decimal sum = 0;
        decimal avg = 0;
        decimal max = -99999999;
        decimal min = 99999999;

        while (input != 0)
        {
            Console.Write("Enter a number, put 0 to stop: ");
            input = decimal.Parse(Console.ReadLine());

            //if they put zero
            if (input == 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum = sum + numbers[i];
                }
                avg = sum / numbers.Count;
                Console.WriteLine($"Average = {avg}");
                Console.WriteLine($"Largest Number = {max}");
                Console.WriteLine($"Smallest positive = {min}");
                numbers.Sort();
                Console.WriteLine("List sorted");
                foreach (decimal x in numbers)
                {
                    Console.WriteLine(x);
                }
            }
        
            else
            {
                //add the input to the list
                numbers.Add(input);
            
                //get max number
                if (input > max)
                {
                    max = input;
                }
                //get min number
                if (input < min && input > 0)
                {
                    min = input;
                }
            }
        }
    }
}