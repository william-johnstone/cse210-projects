class Reflecting : Activity
{
    static readonly List<string> reflectingPrompts = new()
    {
        "Think of a time when you stood up for someone else."
        ,"Think of a time when you did something really difficult."
        ,"Think of a time when you helped someone in need."
        ,"Think of a time when you did something truly selfless."
    };
    static readonly List<string> reflectingQuestions = new()
    {
        "Why was this experience meaningful to you?"
        ,"Have you ever done anything like this before?"
        ,"How did you get started?"
        ,"How did you feel when it was complete?"
        ,"What made this time different than other times when you were not as successful?"
        ,"What is your favorite thing about this experience?"
        ,"What could you learn from this experience that applies to other situations?"
        ,"What did you learn about yourself through this experience?"
        ,"How can you keep this experience in mind in the future?"
    };

    //get  count of things in the list and create a random number
    static readonly int countPrompt = reflectingPrompts.Count;
    static readonly int countQuestion = reflectingQuestions.Count;
    private DateTime _reflectingStart;
    private DateTime _reflectingEnd;
    private DateTime  _currentTime;
    private DateTime _futureTime;
    public void ReflectingStart(int duration)
    {
        _reflectingStart = DateTime.Now;
        _currentTime = _reflectingStart;
        _futureTime = _reflectingStart.AddSeconds(duration);
        Random rnd1 = new();
        int tmpIndexPrompt = rnd1.Next(0, reflectingPrompts.Count());
        while (_currentTime < _futureTime)
        {
            Console.Clear();            
            Console.WriteLine($"Prompt: {reflectingPrompts[tmpIndexPrompt]}");
            Random rnd2 = new();
            int tmpIndexQuestion = rnd2.Next(0, reflectingQuestions.Count());
            Console.WriteLine($"Question: {reflectingQuestions[tmpIndexQuestion]}");
            Spinner(8);

            _currentTime = DateTime.Now;
        }
        //after the breathing loop wrap up messages
        Console.Clear();
        _reflectingEnd = DateTime.Now;
        Console.WriteLine("Great job on finishing!");
        int totalTime = Convert.ToInt16(System.Math.Abs(_reflectingEnd.Subtract(_reflectingStart).TotalSeconds));
        Console.WriteLine($"You spent {totalTime} seconds on this activity");
        Spinner(5);
    }
}