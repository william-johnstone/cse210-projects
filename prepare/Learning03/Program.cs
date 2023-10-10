using System;

class Program
{
    
    static void Main(string[] args)
    {
        int top1 = 0;
        int bottom1 = 0;
        
        Console.Write("Top number = ");
        top1 = int.Parse(Console.ReadLine());

        Console.Write("Bottom number = ");
        bottom1 = int.Parse(Console.ReadLine());

        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(top1, bottom1);
        Fraction frac3 = new Fraction(bottom1, top1);
        Fraction frac4 = new Fraction(bottom1, bottom1);

        Console.WriteLine("frac1 = private values");
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine("frac2 = inputted values");
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine("frac3 = inputted bottom, top");
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine("frac4 = inputted bottom, bottom");
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
        Console.WriteLine();
    }

}