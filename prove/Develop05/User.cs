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
            Console.WriteLine($"You have {goals.Count()} goals.");
            score += goals[goalIndex].Value;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            goals[i].DisplayDetails();
        }

        Console.WriteLine($"Total Score: {score}");
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