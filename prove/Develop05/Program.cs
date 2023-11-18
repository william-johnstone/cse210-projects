class Program
{
    /*  This is the main program where the menu and some of the responses information will be inputted
        Have a User class to allow potential for multiple users in the future, the user object is instantiated in Main
        Can save and load goals with | delimeter.
        using an exception on loading file to detect if it fits the correct format
        methods are clean and names are easy to understand
        using bool conditions to get valid values
        using switches to quickly get to correct methods
        variables are private or protected
        derived class used
        method overriding used for checklist class
        using Thread.Sleep(1500) for a pause to cleanup screen between various actions
        
    */
    static void Main()
    {
        User user = new User();
        
        Console.Clear(); //clear all the load stuff

        //loop for  menu
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
                    Console.Clear();
                    Console.WriteLine("Creating a new goal!");
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("a. Simple Goal");
                    Console.WriteLine("b. Eternal Goal");
                    Console.WriteLine("c. Checklist Goal");
                    Console.Write("Enter your choice: ");
                    string goalTypeChoice = Console.ReadLine();

                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();

                    Console.Write("Enter goal value: ");
                    int goalValue = int.Parse(Console.ReadLine());

                    Goal goal = null;

                    switch (goalTypeChoice)
                    {
                        case "a":
                            goal = new SimpleGoal(goalName, goalDescription, goalValue);
                            break;
                        case "b":
                            goal = new EternalGoal(goalName, goalDescription, goalValue);
                            break;
                        case "c":
                            Console.Write("How many times do you need to complete the checklist goal: ");
                            int requiredEvents = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonus = int.Parse(Console.ReadLine());
                            goal = new ChecklistGoal(goalName, goalDescription, goalValue, requiredEvents, bonus);
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                    }

                    if (goal != null)
                    {
                        user.AddGoal(goal);
                        Console.WriteLine("Goal created successfully!");
                        Thread.Sleep(1500);
                        Console.Clear();
                    }

                    break;

                case "2":
                    Console.Clear();
                    user.DisplayGoals();
                    Thread.Sleep(1500);
                    break;

                case "3":
                    Console.Clear();
                    Console.Write("Enter file name to save goals (example: goals.txt): ");
                    string saveFileName = Console.ReadLine();
                    user.SaveGoalsToFile(saveFileName);
                    Console.WriteLine("Goals saved to file.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;

                case "4":
                    Console.Clear();
                    Console.Write("Enter file name to load goals (example: goals.txt): ");
                    string loadFileName = Console.ReadLine();
                    user.LoadGoalsFromFile(loadFileName);
                    Console.WriteLine("Goals loaded from file.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;

                case "5":
                    Console.Clear();
                    Console.Write("Enter the goal number you want to record an event: ");
                    user.DisplayGoals();
                    int recordEventIndex = int.Parse(Console.ReadLine());
                    recordEventIndex = recordEventIndex -1;
                    user.RecordEvent(recordEventIndex);
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;

                case "6":
                    Console.Clear();
                    Console.WriteLine("Thank you for participating!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine($"You entered {choice}, please enter a valid number");
                    Thread.Sleep(1500);              
                    break;
            }

            Console.WriteLine();
        }
    }
}