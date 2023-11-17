public class Goal
{
    private int _amountPoints;
    private bool _goalCompleted;
    private string _name;
    private int _goalType;
    private string _goalName;
    private int _goalPoints;

    public Goal(int goalType, string goalName, int goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalPoints = goalPoints;
    }

    public virtual string GetName()
    {
        return _name;
    }
    public virtual int GetPoints()
    {
        return _amountPoints;
    }
    public virtual void RecordEvent()
    {
        _goalCompleted = true;
        Console.WriteLine($"Goal Event marked for {_name}.");
    }

    public bool IsGoalComplete()
    {
        return _goalCompleted;
    }
    protected void SetGoalComplete(bool completed)
    {
        _goalCompleted = completed;
    }
    public virtual void CreateGoal()
    {
        //override allowed for derived classes
    }
}