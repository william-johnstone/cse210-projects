public class EternalGoal : Goal
{
    public EternalGoal(int goalType, string goalName, string goalDescription, int goalPoints) : base(goalType, goalName, goalPoints)
    {
        
    }

    public override int GetPoints()
    {
        return base.GetPoints();
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine($"Eternal goal '{GetName}' Points added: {GetPoints}.");
    }
}