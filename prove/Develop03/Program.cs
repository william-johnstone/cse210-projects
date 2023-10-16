using System;


class Program
{
    
    
    static void Main(string[] args)
    {
        Console.Clear();
        string userInput = "";
        //set up the reference, scripture, and the memorizer classes that need to persist globally
        Scripture scripture = new Scripture();
        //Reference reference = new Reference();
        
        //calls the method for ScriptureLoad
        scripture.ScriptureLoad();
        Console.WriteLine(scripture.ScriptureFormatted);
        //loop through the scripture or allow quit
        while (userInput != "quit")
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine(scripture.ModifiedScripture);
            if (scripture.Complete)
            {
                userInput = "quit";
            }
            //check if there are no words left to quit
        }
        Console.WriteLine("Goodbye");
    }
}