using System;

//classes: Journal, Prompt, Entry, FileManager
//journal class - manage entries, add entries, display entries, save entries to file, load entries from file
//entry class - store entries and data
//prompt class - list of prompts and randomly select one

class Program
{
    class Messages
    {
        string message = "";
        public string DisplayIntro()
            {
                Console.Clear();
                message = "Welcome to the journal app!";
                return message;
            }

        public string DisplayOutro()
            {
                message = "Thank you for using the app!";
                return message;
            }
    }
    
    static void Main(string[] args)
    {
        int choice = 0;
        Messages myMessage = new Messages();
        Console.WriteLine(myMessage.DisplayIntro());

        Journal myJournal = new Journal();

        while (choice != 5)
        {
            //choices 1 through 5
            Console.Clear();
            Console.WriteLine("1 - Write a new entry from prompt.");
            Console.WriteLine("2 - Display the journal entries.");
            Console.WriteLine("3 - Save the journal to a file.");
            Console.WriteLine("4 - Load the journal from a file.");
            Console.WriteLine("5 - Quit the program.");
            Console.Write("Please input your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Prompt newPrompt = new Prompt();
                newPrompt.PromptPick();
                Entry newEntry = new Entry();
                newEntry.AddEntry();
                myJournal.entries.Add(newEntry);

            }
            else if (choice == 2)
            {
                myJournal.DisplayEntries();
            }
            else if (choice == 3)
            {
                myJournal.FileSave();
            }
            else if (choice == 4)
            {
                Journal.FileLoad();
            }
            else if (choice == 5)
            {
                Console.WriteLine(myMessage.DisplayOutro());
            }
            else 
            {
                Console.WriteLine("Invalid Entry");
                Console.ReadKey(true);
            }
            //for showing the choice
            //Console.WriteLine(choice);
        }
    }
}