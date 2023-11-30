class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() +
            $": Speed {_speed:F1} kph, Pace: {GetPace():F1} min per km";
    }
}