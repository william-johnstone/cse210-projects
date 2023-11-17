public class ChecklistGoal : Goal
{
    public int RequiredTimes { get; set; }
    public int TimesCompleted { get; set; }
    public int BonusValue { get; set; }

    public ChecklistGoal(string name, int targetCount, int scoreValue, int bonusValue) : base(name, "checklist", scoreValue)
    {
        RequiredTimes = targetCount;
        BonusValue = bonusValue;
        TimesCompleted = 0;
    }

    public void MarkComplete()
    {
        TimesCompleted++;
        if (TimesCompleted == RequiredTimes)
        {
            _scoreValue += BonusValue;
        }
    }

    public override void TrackProgress()
    {
        Console.WriteLine($"Goal {_name} has been completed {TimesCompleted} times out of {RequiredTimes} required times.");
    }

    public override int CalculateScore()
    {
        return _scoreValue;
    }
}