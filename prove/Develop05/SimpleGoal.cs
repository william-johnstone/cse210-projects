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