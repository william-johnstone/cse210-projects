public class EternalGoal : Goal
{
    public int TotalPointsEarned { get; set; }

    public EternalGoal(string name, int scoreValue) : base(name, "eternal", scoreValue)
    {
        TotalPointsEarned = 0;
    }

    public void IncrementProgress()
    {
        TotalPointsEarned += _scoreValue;
    }

    public override void TrackProgress()
    {
        Console.WriteLine($"Goal {_name} has {TotalPointsEarned} points earned so far.");
    }
}