class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GenerateStandardDetails()
    {
        return $"Standard Details:\nTitle: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetFullAddress()}\n";
    }

    public string GenerateFullDetails()
    {
        return $"Full Details:\n{GenerateStandardDetails()}";
    }

    public string GenerateShortDescription()
    {
        return $"Short Description:\nType: {GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}\n-------------------------\n";
    }
}