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