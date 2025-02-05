class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GenerateFullDetailsForOutdoorGathering()
    {
        return $"{GenerateFullDetails()}Type: Outdoor Gathering\nWeather: {_weather}\n";
    }
}