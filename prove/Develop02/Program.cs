using System;

//classes: Journal, Prompt, Entry, FileManager
//journal class - manage entries, add entries, display entries, save entries to file, load entries from file
//entry class - store entries and data
//prompt class - list of prompts and randomly select one

class Program
{
    static void Main(string[] args)
    {
        string choice = "Y";
        while (choice != "Q")
        {
            //choices 1 through 5
            Console.WriteLine("1 - Write a new entry from prompt.");
            Console.WriteLine("2 - Display the journal entries.");
            Console.WriteLine("3 - Save the journal to a file.");
            Console.WriteLine("4 - Load the journal from a file.");
            Console.WriteLine("Q - Quit the program.");
            Console.Write("Please input your choice: ");
            choice = Console.ReadLine();

            choice = choice.ToUpper();
            Console.WriteLine(choice);
        }
    }
}