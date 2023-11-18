// Checklist goal class
public class ChecklistGoal : Goal
{
    private int _requiredEvents;
    private int _completedEvents;
    
    public ChecklistGoal(string name, string description, int value, int requiredEvents, int bonus) : base(name, description, value)
    {
        this._requiredEvents = requiredEvents;
        this._completedEvents = 0;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for checklist goal '{Name}'. You gained {Value} points.");

        _completedEvents++;
        if (_completedEvents == _requiredEvents)
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal '{Name}' and earned an extra bonus.");
            Console.WriteLine($"You gained an additional {Bonus} points as a bonus.");
        }
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Checklist Goal] Name: {Name}, Description: {Description}, Value: {Value}, Required Events: {_requiredEvents}, Completed Events: {_completedEvents}, Bonus: {Bonus}");
    }
}
