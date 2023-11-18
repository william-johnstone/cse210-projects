using System;
using System.Collections.Generic;
using System.IO;

// Base class for all goals
public abstract class Goal
{
    private string name;
    private int value;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public string Name
    {
        get { return name; }
    }

    public int Value
    {
        get { return value; }
    }

    // Abstract method to record an event and update the score
    public abstract void RecordEvent();

    // Abstract method to display goal details
    public abstract void DisplayDetails();
}

// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' completed! You gained {Value} points.");
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Simple Goal] Name: {Name}, Value: {Value}");
    }
}

// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress for eternal goal '{Name}'. You gained {Value} points.");
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Eternal Goal] Name: {Name}, Value: {Value}");
    }
}

// Checklist goal class
public class ChecklistGoal : Goal
{
    private int requiredEvents;
    private int completedEvents;

    public ChecklistGoal(string name, int value, int requiredEvents) : base(name, value)
    {
        this.requiredEvents = requiredEvents;
        this.completedEvents = 0;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for checklist goal '{Name}'. You gained {Value} points.");

        completedEvents++;
        if (completedEvents == requiredEvents)
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal '{Name}' and earned an extra bonus.");
            Console.WriteLine($"You gained an additional {Value * 2} points as a bonus.");
        }
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Checklist Goal] Name: {Name}, Value: {Value}, Required Events: {requiredEvents}, Completed Events: {completedEvents}");
    }
}

// User class
public class User
{
    private List<Goal> goals;
    private int score;

    public User()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            score += goals[goalIndex].Value;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            goals[i].DisplayDetails();
        }

        Console.WriteLine($"\nTotal Score: {score}\n");
    }

    public void SaveGoalsToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value}");
            }
        }
    }

    public void LoadGoalsFromFile(string fileName)
    {
        goals.Clear();
        score = 0;

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string goalType = parts[0];
                        string goalName = parts[1];
                        int goalValue = int.Parse(parts[2]);

                        Goal goal;

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal(goalName, goalValue);
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(goalName, goalValue);
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal(goalName, goalValue, 3); // Assuming a default of 3 required events for checklist goals
                                break;
                            default:
                                goal = null;
                                break;
                        }

                        if (goal != null)
                        {
                            goals.Add(goal);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals from file: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        User user = new User();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("a. Simple Goal");
                    Console.WriteLine("b. Eternal Goal");
                    Console.WriteLine("c. Checklist Goal");
                    Console.Write("Enter your choice: ");
                    string goalTypeChoice = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();

                    Console.Write("Enter goal value: ");
                    int goalValue = int.Parse(Console.ReadLine());

                    Goal goal = null;

                    switch (goalTypeChoice)
                    {
                        case "a":
                            goal = new SimpleGoal(goalName, goalValue);
                            break;
                        case "b":
                            goal = new EternalGoal(goalName, goalValue);
                            break;
                        case "c":
                            Console.Write("Enter required events for the checklist goal: ");
                            int requiredEvents = int.Parse(Console.ReadLine());
                            goal = new ChecklistGoal(goalName, goalValue, requiredEvents);
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    if (goal != null)
                    {
                        user.AddGoal(goal);
                        Console.WriteLine("Goal created successfully!");
                    }

                    break;

                case "2":
                    user.DisplayGoals();
                    break;

                case "3":
                    Console.Write("Enter file name to save goals: ");
                    string saveFileName = Console.ReadLine();
                    user.SaveGoalsToFile(saveFileName);
                    Console.WriteLine("Goals saved to file.");
                    break;

                case "4":
                    Console.Write("Enter file name to load goals: ");
                    string loadFileName = Console.ReadLine();
                    user.LoadGoalsFromFile(loadFileName);
                    Console.WriteLine("Goals loaded from file.");
                    break;

                case "5":
                    Console.Write("Enter the index of the goal to record an event: ");
                    int recordEventIndex = int.Parse(Console.ReadLine());
                    user.RecordEvent(recordEventIndex);
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
