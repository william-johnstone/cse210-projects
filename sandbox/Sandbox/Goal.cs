public class Goal
{
    private int _score;
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }
    private string _name;
    public string GetName()
        {
            return _name;
        }
    private string _type;
    public string GetType()
        {
            return _type;
        }
    private int _scoreValue;
    public int GetScoreValue()
        {
            return _scoreValue;
        }

    

    public void CreateGoal()
    {
        Console.Write("Enter the name of the new goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        int type = int.Parse(Console.ReadLine());

        Goal newGoal = new Goal();

        switch (type)
        {
            case 1:
                Console.Write("Enter the score value: ");
                int scoreValue = int.Parse(Console.ReadLine());
                newGoal = new SimpleGoal(name, scoreValue);
                break;

            case 2:
                Console.Write("Enter the score value: ");
                scoreValue = int.Parse(Console.ReadLine());
                newGoal = new EternalGoal(name, scoreValue);
                break;

            case 3:
                Console.Write("Enter the target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the score value: ");
                scoreValue = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus value: ");
                int bonusValue = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, targetCount, scoreValue, bonusValue);
                break;

            default:
                Console.WriteLine("Invalid option. Please try again.");
                return;
        }
        newGoal.DisplayGoals();
        Console.WriteLine($"Goal '{name}' created successfully.");
    }
    public void RecordEvent()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Goal goal = goals.Find(goal => goal.Name == name);

        if (goal == null)
        {
            Console.WriteLine($"Goal '{name}' not found. Please try again.");
            return;
        }

        goal.TrackProgress();
        score += goal._scoreValue;
        Console.WriteLine($"Event recorded for goal '{name}'. You have gained {goal._scoreValue} points.");
    }

     public void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        Console.WriteLine("Current goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{char.ToUpper(goal._type[0]) + goal._type.Substring(1)} Goal '{goal._name}' with a score value of {goal._scoreValue}.");
        }
    }

    public void SaveProgress(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {

            writer.WriteLine(score);

            foreach (Goal goal in goals)
            {
                writer.WriteLine(GetType());
                writer.WriteLine(GetName());
                writer.WriteLine(GetScoreValue());
                if (goal is EternalGoal)
                {
                    writer.WriteLine(((EternalGoal)goal));
                }
                else if (goal is ChecklistGoal)
                {
                    writer.WriteLine(((ChecklistGoal)goal).TimesCompleted);
                    writer.WriteLine(((ChecklistGoal)goal).BonusValue);
                }
            }
        }
        Console.WriteLine("Goals and score saved successfully.");
    }

    public void LoadProgress(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            score = int.Parse(reader.ReadLine());

            while (!reader.EndOfStream)
            {
                string type = reader.ReadLine();
                string name = reader.ReadLine();
                int scoreValue = int.Parse(reader.ReadLine());
                Goal goal;

                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(name, scoreValue);
                        break;

                    case "EternalGoal":
                        bool isCompleted = bool.Parse(reader.ReadLine());
                        goal = new EternalGoal(name, scoreValue);
                        break;

                    case "ChecklistGoal":
                        int targetCount = int.Parse(reader.ReadLine());
                        int bonusValue = int.Parse(reader.ReadLine());
                        goal = new ChecklistGoal(name, targetCount, scoreValue, bonusValue);
                        break;

                    default:
                        Console.WriteLine("Invalid goal type found in file. Skipping.");
                        continue;
                }

                goals.Add(goal);
            }
        }
        Console.WriteLine("Goals and score loaded successfully.");
    }
    public virtual void TrackProgress() { }

    public virtual int CalculateScore() { return _scoreValue; }
    public override string ToString() { return base.ToString(); }
}