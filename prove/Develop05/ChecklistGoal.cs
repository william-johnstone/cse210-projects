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
