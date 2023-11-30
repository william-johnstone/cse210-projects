class Activity
{
    protected DateTime _date;
    protected int _durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;  // Base class has no direct distance calculation
    }

    public virtual double GetSpeed()
    {
        return 0;  // Base class has no direct speed calculation
    }

    public virtual double GetPace()
    {
        return 0;  // Base class has no direct pace calculation
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} - {GetType().Name} ({_durationMinutes} min)";
    }
}