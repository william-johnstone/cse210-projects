public class SimpleGoal : Goal
{
    public bool Completed { get; set; }

    public SimpleGoal(string name, int scoreValue) : base(name, "simple", scoreValue)
    {
        Completed = false;
    }

    public void MarkComplete()
    {
        Completed = true;
    }

    public override void TrackProgress()
    {
        if (Completed)
        {
            Console.WriteLine($"Goal {_name} is complete.");
        }
        else
        {
            Console.WriteLine($"Goal {_name} is not yet complete.");
        }
    }
}