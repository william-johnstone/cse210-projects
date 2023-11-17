public class ChecklistGoal : Goal
{
    private int _goalChecklistCount;
    private int _goalChecklistCountMax;
    //goalType, goalName, goalDescription, goalCompletionStatus, goalPoints, goalChecklistMax, goalChecklistCount
    public ChecklistGoal(int goalType, string goalName, string goalDescription, bool goalCompletionStatus, int goalPoints, int goalChecklistMax, int goalChecklistCount) : base(goalType, goalName, goalPoints)
    {

    }
    private void ChecklistCount(int goalChecklistCount)
    {
        _goalChecklistCount = goalChecklistCount;
    }
    private void ChecklistCountMax(int goalChecklistMax)
    {
        _goalChecklistCountMax = goalChecklistMax;
    }

    public override int GetPoints()
    {
        if (IsGoalComplete())
        {
            return (base.GetPoints() * _goalChecklistCount) + base.GetPoints();
        }
        else 
        {
            return base.GetPoints() * _goalChecklistCount;
        }
    }
    public override void RecordEvent()
    {
        base.RecordEvent();
        _goalChecklistCount++;

        if (_goalChecklistCount == _goalChecklistCountMax)
        {
            SetGoalComplete(true);
            Console.WriteLine($"Checklist goal '{GetName}' is now complete.");
        }
    }

}