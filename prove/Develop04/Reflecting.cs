class Reflecting : Activity
{
    private readonly string _reflectingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
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

    private string ReflectingMessage()
    {
        return _reflectingDescription;
    }
    //get  count of things in the list and create a random number
    static readonly int countPrompt = reflectingPrompts.Count;
    static readonly int countQuestion = reflectingQuestions.Count;


    public void ReflectingStart(int duration)
    {
        int reflectingCounter = 0;
        int shortDuration = 5;
        int parts = duration / shortDuration;
        string reflectingMessage = ReflectingMessage();
        while (reflectingCounter < parts)
        {
            int rndReflectingPrompt = new Random().Next(0, countPrompt);
            int rndReflectingQuestion = new Random().Next(0, countQuestion);
            string question = reflectingQuestions[rndReflectingQuestion];
            string prompt = reflectingPrompts[rndReflectingPrompt];
            Console.Clear();
            Console.WriteLine($"{reflectingMessage}");
            Thread.Sleep(100);
            Console.WriteLine($"{prompt}");
            Console.WriteLine($"{question}");            
            ActivityTime(shortDuration);
            reflectingCounter++;
        }
    }
}