public class SimpleGoal : Goal
{
    //goalType, goalName, goalDescription, goalCompletionStatus, goalPoints
    public SimpleGoal(int goalType, string goalName, string goalDescription, bool goalCompletionStatus, int goalPoints) : base(goalType, goalName, goalPoints)
    {

    }

    public override int GetPoints()
    {
        return base.GetPoints();
    }
}