using System;
class Program
{
    
    
    static void Main(string[] args)
    {
        Console.Clear();
        string userInput = "";
        //set up the scripture class that need to persist throughout the looping
        Scripture scripture = new Scripture();
        
        //calls the method for ScriptureLoad
        scripture.ScriptureLoad();
        //write out the scripture from the OriginalScriptureFormat method
        Console.WriteLine(scripture.OriginalScriptureFormat);
        //loop through the scripture or allow quit
        while (userInput != "quit")
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine().ToLower();
            //clears the screen
            Console.Clear(); 
            //Write out the scripture from the ModifiedScripture method
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