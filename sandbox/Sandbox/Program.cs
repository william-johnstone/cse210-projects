using System;
class Program
{
    static Reference reference = new Reference();
    static Scripture scripture = new Scripture();
    //this variable could be used to create a custom file
    static string _filename = "scriptures.txt";
    //used to help get the lines information
    static string[] ReadFile()
    {
        return File.ReadAllLines(_filename);
    }

    static void ScriptureLoad()
    {
        string[] _fileContent = ReadFile();
        int _lineScripture = new Random().Next(0, _fileContent.Count());
        string line = _fileContent[_lineScripture].Replace("\"", "");
        string[] lineParts = line.Split('|');
        string _scriptureFullReference = lineParts[0];
        string _scriptureFullWords = lineParts[1];
        reference.ReferenceSource = _scriptureFullReference;
        scripture.ScriptureSource = _scriptureFullWords;
    }
    static void Main(string[] args)
    {
        Console.Clear();
        ScriptureLoad();
        Console.Write(reference.GetReference());
        Console.Write(scripture.ScriptureSource);
        scripture.ParseScriptureSource();
        string userInput = "";

        //loop through the scripture or allow quit
        while (userInput != "quit")
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine().ToLower();
            //clears the screen
            Console.Clear(); 
            //Write out the scripture from the ModifiedScripture method
            scripture.ChangeWords();
            Console.WriteLine($"{reference.GetReference()} {scripture.GetModified()}");
            if (scripture.IsComplete())
            {
                userInput = "quit";
            }
            //check if there are no words left to quit
        }
        Console.WriteLine("Goodbye");
    }
}