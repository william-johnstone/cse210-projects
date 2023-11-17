using System;
using System.Security.Cryptography.X509Certificates;
class Program
{

    static void Main(string[] args)
    {
        string filename = "";
        //Goal goal = new Goal();
        // display menu options
        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracker program!");
        while (true)
        {
            // read user input
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. View goals and progress");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save progress");
            Console.WriteLine("5. Load progress");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter your choice (1-6): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Goal goal1 = new Goal();
                    goal1.DisplayGoals();
                    break;

                case "2":
                    goal.CreateGoal();
                    break;

                case "3":
                    goal.RecordEvent();
                    break;

                case "4":
                    Console.WriteLine("Enter the name of the file: ");
                    filename = Console.ReadLine();
                    goal.SaveProgress(filename);
                    break;

                case "5":
                    Console.WriteLine("Enter the name of the file: ");
                    filename = Console.ReadLine();
                    goal.LoadProgress(filename);
                    break;

                case "6":
                    //Console.WriteLine("Enter the name of the file: ");
                    //filename = Console.ReadLine();
                    //goalTracker.SaveProgress(filename);
                    Console.WriteLine("Thank you for using the Goal Tracker program!");
                    return;

                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    break;
            }

            goal.DisplayScore();
        }
    }
}