class Breathing : Activity
{
    private readonly string _breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    // public Breathing(string one, string two)
    // {
    //     _breatheIn = one;
    //     _breatheOut = two;
    // }
    private string BreathingMessage()
    {
        return _breathingDescription;
    }
    public void BreathingStart(int duration)
    {
        int breathingCounter = 0;
        int shortDuration = 5;
        int parts = duration / shortDuration;
        string breathingMessage = BreathingMessage();
        while (breathingCounter < parts)
        {
            Console.Clear();
            Console.WriteLine($"{breathingMessage}");
            Console.WriteLine("Breath In...");
            ActivityTime(shortDuration);
            Console.WriteLine("Breath Out...");
            ActivityTime(shortDuration);
            breathingCounter++;
            
        }        
    }
}