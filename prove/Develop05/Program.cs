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