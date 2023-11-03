using System.Diagnostics.Metrics;

class Activity
{
    private string[] _activity;
    private string _activityChoice;
    private DateTime _startTime = DateTime.Now;
    private DateTime _endTime = DateTime.Now;
    private DateTime _currentTime = DateTime.Now;
    int userTime = 0;

    
    //Welcome to the Activity
    public void GetMessage(string activity)
    {
        Console.WriteLine($"Welcome to the {activity}.");
    }
    //This is the start for all activities
    public int CommonStart(int choice)
    {
        //set up variables to handle the dynamic messaging stuff
        _activity = Program.Activities();
        _activityChoice = _activity[choice-1];
        //messages that should be dynamic for each activity
        Console.WriteLine($"Welcome to the {_activityChoice} activity!");
        Console.Write("How many seconds do you want to do the activity? ");
        userTime = Convert.ToInt16(Console.ReadLine());
        Console.Write("Prepare yourself...");
        Thread.Sleep(500);
        return userTime;
    }
    public void ActivityTime(int time)
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(time);
        _currentTime = DateTime.Now;
        while (_currentTime <= _endTime)
        {
            _currentTime = DateTime.Now;
            TimerAnimation();
        }
    }

    public void TimerAnimation()
    {
        string[] _sequence = new string[] { "/", "-", "\\", "|" };
        int _sequencePosition = 1;
        int tacurrent = 0;
        int tamax = 10;
        //loop until current time = end time
        while (tacurrent <= tamax)
        {
            Console.Write(_sequence[_sequencePosition]);
            Thread.Sleep(50);
            Console.SetCursorPosition(Console.CursorLeft - _sequence[_sequencePosition].Length, Console.CursorTop);
            _sequencePosition++;

            if (_sequencePosition > 3)
            {
                _sequencePosition = 0;
            }
            tacurrent++;
        }
    }
}