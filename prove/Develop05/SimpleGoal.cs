// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int value) : base(name, description, value)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' completed! You gained {Value} points.");
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Simple Goal] Name: {Name}, Description: {Description}, Value: {Value}");
    }
}