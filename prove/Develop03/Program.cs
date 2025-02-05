using System;
class Program
{
    //instantiate Reference and Scripture
    static Reference reference = new Reference();
    static Scripture scripture = new Scripture();
    //this variable could be used to create a custom file
    static string _filename = "scriptures.txt";
    //Read all the lines from the file
    static string[] ReadFile()
    {
        return File.ReadAllLines(_filename);
    }
    //this method reads a random line in to use as the reference and scripture
    static void ScriptureLoad()
    {
        string[] _fileContent = ReadFile();
        int _lineScripture = new Random().Next(0, _fileContent.Count());
        string line = _fileContent[_lineScripture].Replace("\"", "");
        string[] lineParts = line.Split('|');
        string _scriptureFullReference = lineParts[0];
        string _scriptureFullWords = lineParts[1];
        reference.referenceSource = _scriptureFullReference;
        scripture.scriptureSource = _scriptureFullWords;
    }
    static void Main(string[] args)
    {
        Console.Clear();
        ScriptureLoad();
        //Call the initial scripture reference and scripture
        Console.WriteLine($"{reference.GetReference()} {scripture.scriptureSource}");
        scripture.ParseScriptureSource();
        string userInput = "";

        //loop through the scripture or allow quit
        while (userInput != "quit")
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine().ToLower();
            //clears the screen
            Console.Clear(); 
            //Write out the scripture from the GetModified method
            scripture.ChangeWords();
            Console.WriteLine($"{reference.GetReference()} {scripture.GetModified()}");
            //check if there are no words left to quit
            if (scripture.IsComplete())
            {
                userInput = "quit";
            }
            
        }
        Console.WriteLine("Goodbye");
    }
}