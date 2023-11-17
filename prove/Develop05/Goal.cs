public class Goal
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int ScoreValue { get; set; }

    public Goal(string name, string type, int scoreValue)
    {
        Name = name;
        Type = type;
        ScoreValue = scoreValue;
    }

    public virtual void TrackProgress() { }

    public virtual int CalculateScore() { return ScoreValue; }

    public override string ToString() { return base.ToString(); }
}