using System;

class Program
{

    static void Main(string[] args)
    {
        string jobinfo = "y";

        Resume myResume = new Resume();
        Console.Write("What is your name? ");
        myResume._name = Console.ReadLine();

        while (jobinfo == "y")
        {
            Job job1 = new Job();

            Console.Write("What is the Job Title? ");
            job1._jobTitle = Console.ReadLine();

            Console.Write("What is the Company? ");
            job1._company = Console.ReadLine();

            Console.Write("What is the Start Year? ");
            job1._startYear = int.Parse(Console.ReadLine());

            Console.Write("What is the End Year? ");
            job1._endYear = int.Parse(Console.ReadLine());

            myResume._jobs.Add(job1);

            Console.Write("Go again? (y/n)");
            jobinfo = Console.ReadLine();
            
        }
        
        myResume.Display();
    }
}