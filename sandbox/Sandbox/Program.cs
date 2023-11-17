using System;
using System.Collections;
using System.IO;
class Program
{
    static readonly List<string> menu = new()
    {
        "Create a new goal"
        ,"List Goals"
        ,"Save Goals"
        ,"Load Goals"
        ,"Record an event"
        ,"Quit"
    };
    static void Menu()
    {
        int choice = 1;
        foreach (string item in menu)
        {
            Console.WriteLine($"{choice} - {item}");
            choice++;
        }
    }
    static void Main(string[] args)
    {
        string _filename = "";
        List<Goal> goals = LoadGoals(_filename);
        
        bool exit = true;
        // display menu options
        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracker program!");
        while (exit)
        {
            Console.Clear();
            Console.WriteLine("Please choose an option:");
            Menu();
            Console.Write("\nEnter your choice (1-6): ");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                switch (input)
                {
                    case 1:
                        CreateGoal(goals);
                        break;

                    case 2:
                        //ShowGoals(goals);
                        break;

                    case 3:
                        Console.WriteLine("Enter the filename to save (will auto save as .txt): ");
                        _filename = Console.ReadLine();
                        //SaveGoals(_filename);
                        break;

                    case 4:
                        Console.WriteLine("Enter the filename to load (will auto append .txt): ");
                        _filename = Console.ReadLine();
                        LoadGoals(_filename);
                        break;

                    case 5:
                        //RecordEvent(goals);
                        break;

                    case 6:
                        Console.WriteLine("Thank you for using the Goal Tracker program!");
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                Console.ReadKey();
            }
        }
    }

    static List<Goal> LoadGoals(string filename)
    {
        List<Goal> loadedGoals = new List<Goal>();
        if (File.Exists($"{filename}.txt"))
        {
            using (StreamReader reader = new StreamReader($"{filename}.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] goalData = line.Split('|');
                    int goalType = int.Parse(goalData[0].Trim());
                    string goalName = goalData[1].Trim();
                    string goalDescription = goalData[2].Trim();
                    bool goalCompletionStatus = bool.Parse(goalData[3].Trim());
                    int goalPoints = int.Parse(goalData[4].Trim());
                    int goalChecklistCount = int.Parse(goalData[5].Trim());
                    int goalChecklistMax = int.Parse(goalData[6].Trim());

                    Goal goal;
                    if (goalType == 1)
                    {
                        goal = new SimpleGoal(goalType, goalName, goalDescription, goalCompletionStatus, goalPoints);
                    }
                    else if (goalType == 2)
                    {
                        goal = new EternalGoal(goalType, goalName, goalDescription, goalPoints);
                    }
                    else{
                        goal = new ChecklistGoal(goalType, goalName, goalDescription, goalCompletionStatus, goalPoints, goalChecklistMax, goalChecklistCount);
                    }
                    loadedGoals.Add(goal);
                }
            }
        }
        else
        {
            Console.WriteLine("No goals found in file.  Loading empty list");
        }
        return loadedGoals;
    }
    public static string[] GoalChoices()
    {
        string[] goalChoice = {"Simple Goal", "Eternal Goal", "Checklist Goal"};
        return goalChoice;
    }
    private static void CreateGoal(List<Goal> goals)
    {
        int i = 0;
        bool goalCompletionStatus = false;
        int goalChecklistMax = 0;
        int goalChecklistCount = 0;

        Console.Clear();
        string[] goalChoice = GoalChoices();
        int goalChoiceCount = goalChoice.Count();
        Console.WriteLine("---------CREATE A GOAL---------");
        Console.WriteLine("The types of Goals are:");
        while (i < goalChoiceCount)
        {
            Console.WriteLine($"   {i+1}. {goalChoice[i]}");
            i++;
        }
        int goalType;
        while (!int.TryParse(Console.ReadLine(), out goalType) || (goalType < 1 || goalType > 3))
        {
            Console.WriteLine("Invalid choice, please enter a number 1, 2, or 3.");
            Console.WriteLine("Select Goal Type: ");
        }
        Console.Write("Enter Goal Name: ");
        string goalName = Console.ReadLine();
        Console.Write("Enter Goal Description: ");
        string goalDescription = Console.ReadLine();
        Console.Write("Enter Goal Points: ");
        int goalPoints;
        while (!int.TryParse(Console.ReadLine(), out goalPoints))
        {
            Console.Clear();
            Console.WriteLine("Please enter a whole number.");
            Console.Write("Enter Goal points: ");
        }
        if (goalType == 3)
        {
            Console.Write("How many times to complete this goal? ");
            Console.ReadLine();
            while (!int.TryParse(Console.ReadLine(), out goalChecklistMax))
            {
                Console.Clear();
                Console.WriteLine("Please enter a whole number.");
                Console.Write("Enter how many times to complete this goal: ");
            }
        }

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(goalType, goalName, goalDescription, goalCompletionStatus ,goalPoints);
                break;
            case 2:
                goal = new EternalGoal(goalType, goalName, goalDescription, goalPoints);
                break;
            case 3:
                goal = new ChecklistGoal(goalType, goalName, goalDescription, goalCompletionStatus, goalPoints, goalChecklistMax, goalChecklistCount);
                break;
        }
    }
}