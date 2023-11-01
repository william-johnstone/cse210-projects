using System.Diagnostics.Metrics;

class Activity
{
    private string _activity;
    public void GetMessage(string activity)
    {
        Console.WriteLine($"Welcome to the {activity}.");
    }
    public void GetTimer()
    {

    }
    public void ShowPrompt()
    {

    }
    public void IntroMessage()
    {

    }
    public void OutroMessage()
    {

    }
    
    //method to get spinny animation
    private int _counterA;
    private int _counterB;
    private string[] _sequence;
    public void ConsoleSpinner()
    {
        _counterA = 1;
        _counterB = 0;
        _sequence = new string[] { "/", "-", "\\", "|" };
        Console.Write("How many seconds do you want to wait? ");
        int time = Convert.ToInt16(Console.ReadLine());

        while (_counterB <= time)
        {
            _counterA++;
            if (_counterA >= _sequence.Length)
            {
                _counterA = 0;
                _counterB++;
            }
            else
            {
                Console.Write(_sequence[_counterA]);
                Thread.Sleep(50);
                Console.SetCursorPosition(Console.CursorLeft - _sequence[_counterA].Length, Console.CursorTop);
            }
        }
        
    }
}