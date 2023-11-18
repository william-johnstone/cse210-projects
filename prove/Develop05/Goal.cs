// Base class for all goals
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _value;
    private int _bonus;
    public Goal(string name, string description, int value, int bonus=0)
    {
        this._name = name;
        this._description = description;
        this._value = value;
        this._bonus = bonus;
    }

    public string Name
    {
        get { return _name; }
    }
    public string Description
    {
        get {return _description;}
    }
    public int Value
    {
        get { return _value; }
    }
    public int Bonus
    {
        get { return _bonus; }
    }

    // Abstract method to record an event and update the score
    public abstract void RecordEvent();

    // Abstract method to display goal details
    public abstract void DisplayDetails();
}