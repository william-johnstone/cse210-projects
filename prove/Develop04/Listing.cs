class Listing : Activity
{
    static readonly List<string> listingPrompts = new()
    {
        "Who are people that you appreciate?"
        ,"What are personal strengths of yours?"
        ,"Who are people that you have helped this week?"
        ,"When have you felt the Holy Ghost this month?"
        ,"Who are some of your personal heroes?"
    };

    //get  count of things in the list and create a random number
    static readonly int countPrompt = listingPrompts.Count;
    private DateTime _listingStart;
    private DateTime _listingEnd;
    private DateTime _currentTime;
    private DateTime _futureTime;
    public void ReflectingStart(int duration)
    {
        _listingStart = DateTime.Now;
        _currentTime = _listingStart;
        _futureTime = _listingStart.AddSeconds(duration);
        Random rnd1 = new();
        int tmpIndexPrompt = rnd1.Next(0, listingPrompts.Count());
        while (_currentTime < _futureTime)
        {
            int inputCount = 0;
            Console.Clear();            
            Console.WriteLine($"Prompt: {listingPrompts[tmpIndexPrompt]}");
            Spinner(5);
            Console.Clear();
            Console.WriteLine("Get ready...");
            Spinner(3);
            Console.WriteLine("List as many responses as you can to the following prompt:");
            while (_currentTime != _futureTime)
            {
                Console.ReadLine();
                inputCount++;
                _currentTime = DateTime.Now;
            }            
        }
        //after the breathing loop wrap up messages
        Console.Clear();
        _listingEnd = DateTime.Now;
        Console.WriteLine("Great job on finishing!");
        int totalTime = Convert.ToInt16(System.Math.Abs(_listingEnd.Subtract(_listingStart).TotalSeconds));
        Console.WriteLine($"You spent {totalTime} seconds on this activity");
        Spinner(5);
    }
}