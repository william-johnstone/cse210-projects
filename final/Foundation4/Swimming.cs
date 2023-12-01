class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;  // Convert laps to miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_durationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _durationMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() +
            $": Laps ({_laps}), Distance ({GetDistance():F1} km), Speed ({GetSpeed():F1} mph), Pace: ({GetPace():F1} min per mile)\n";
    }
}