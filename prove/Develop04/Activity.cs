using System.Diagnostics.Metrics;

class Activity
{
    private readonly string[] _activityDescription = 
    {
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        ,"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        ,"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    };
    private string[] _activity;
    private string _activityChoice;
    private DateTime _startTime = DateTime.Now;
    private DateTime _endTime = DateTime.Now;
    private DateTime _currentTime = DateTime.Now;
    int userTime = 0;
    //This is the start for all activities
    public int CommonStart(int choice)
    {
        Console.Clear();
        //set up variables to handle the dynamic messaging stuff
        _activity = Program.Activities();
        _activityChoice = _activity[choice-1];
        //messages that should be dynamic for each activity
        Console.WriteLine($"Welcome to the {_activityChoice} activity!");
        Console.WriteLine($"{_activityDescription[choice-1]}");
        Console.Write("How many seconds do you want to do the activity? ");
        userTime = Convert.ToInt16(Console.ReadLine());
        Console.Write("Prepare yourself...");
        Thread.Sleep(5000);
        return userTime;
    }
    public void Spinner(int time)
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(time);
        _currentTime = DateTime.Now;
        while (_currentTime < _endTime)
        {
            _currentTime = DateTime.Now;
            TimerAnimation();
        }
    }
    //This does the spinning animation in a loop for a short duration
    public void TimerAnimation()
    {
        string[] _sequence = new string[] { "/", "-", "\\", "|" };
        int _sequencePosition = 1;
        int tacurrent = 0;
        int tamax = 10;
        //loop a few times
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