// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int value) : base(name, description, value)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress for eternal goal '{Name}'. You gained {Value} points.");
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Eternal Goal] Name: {Name}, Description: {Description}, Value: {Value}");
    }
}