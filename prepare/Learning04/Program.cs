using System;

namespace library_demo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Assignment assign1 = new Assignment("Samuel Bennet", "Multiplication");
            Console.WriteLine(assign1.GetSummary());
            Console.WriteLine("-----------");

            MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(math1.GetSummary());
            Console.WriteLine(math1.GetHomeworkList());
            Console.WriteLine("-----------");

            WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(writing1.GetSummary());
            Console.WriteLine(writing1.GetWritingInformation());
        }
    }
}