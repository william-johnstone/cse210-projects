// Base class for all goals
public abstract class Goal
{
    private string name;
    private int value;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public string Name
    {
        get { return name; }
    }

    public int Value
    {
        get { return value; }
    }

    // Abstract method to record an event and update the score
    public abstract void RecordEvent();

    // Abstract method to display goal details
    public abstract void DisplayDetails();
}