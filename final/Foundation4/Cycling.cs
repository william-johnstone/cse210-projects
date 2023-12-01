class Cycling : Activity
{
    private double _distance;

    public Cycling(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _durationMinutes * 60.0;
    }

    public override double GetPace()
    {
        return _durationMinutes / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() +
            $": Distance ({GetDistance():F1} miles), Speed ({GetSpeed():F1} mph), Pace: ({GetPace():F1} min per mile)\n";
    }
}