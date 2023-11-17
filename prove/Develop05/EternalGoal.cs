public class EternalGoal : Goal
{
    public int TotalPointsEarned { get; set; }

    public EternalGoal(string name, int scoreValue) : base(name, "eternal", scoreValue)
    {
        TotalPointsEarned = 0;
    }

    public void IncrementProgress()
    {
        TotalPointsEarned += ScoreValue;
    }

    public override void TrackProgress()
    {
        Console.WriteLine($"Goal {Name} has {TotalPointsEarned} points earned so far.");
    }
}