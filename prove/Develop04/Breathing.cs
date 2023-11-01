class Breathing : Activity
{
    private readonly string _breathingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    static readonly List<string> breathingPrompts = new()
        {"Think of a time when you stood up for someone else."
        ,"Think of a time when you did something really difficult."
        ,"Think of a time when you helped someone in need."
        ,"Think of a time when you did something truly selfless."
        };

    static readonly List<string> breathingQuestions = new()
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
    }
    //get  count of things in the list and create a random number
    static readonly int countPrompt = breathingPrompts.Count;
    static readonly int countQuestion = breathingQuestions.Count;
    private readonly int rndPrompt = new Random().Next(0, countPrompt);
    public Breathing(string one, string two)
    {
        _one = one;
        _two = two;
    }
    public string GetOne()
        {
            return _one;
        }
        public string GetTwo()
        {
            return _two;
        }

        public string GetSummary()
        {
            return $"{_one} - {_two}";
        }
}