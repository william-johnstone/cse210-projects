class Breathing : Activity
{
    private DateTime _breathingStart;
    private DateTime _breathingEnd;
    private DateTime  _currentTime;
    private DateTime _futureTime;
    public void BreathPause()
    {
        for (int a = 5; a>= 0; a--)
        {
            Console.Write("\rBreath for {0:00} ", a );
            Thread.Sleep(1000);
        }
    }
    public void BreathingStart(int duration)
    {
        _breathingStart = DateTime.Now;
        _currentTime = _breathingStart;
        _futureTime = _breathingStart.AddSeconds(duration);
        while (_currentTime < _futureTime)
        {
            Console.Clear();
            Console.WriteLine("Breath In...");
            BreathPause();
            Console.Clear();
            Console.WriteLine("Breath Out...");
            BreathPause();
            _currentTime = DateTime.Now;
        }
        //after the breathing loop wrap up messages
        Console.Clear();
        _breathingEnd = DateTime.Now;
        Console.WriteLine("Great job on finishing!");
        int totalTime = Convert.ToInt16(System.Math.Abs(_breathingEnd.Subtract(_breathingStart).TotalSeconds));
        Console.WriteLine($"You spent {totalTime} seconds on this activity");
        Spinner(5);
    }
}