using System;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public string _filename = "journal.txt";
    
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.ViewEntry();
        }
        Console.ReadKey(true);
    }

    public void FileSave()
    {    
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.entryDate} | {entry.entryContent}");
            }
        }
    }

    public static List<Entry> FileLoad()
    {
        string _filename = "journal.txt";
        Console.WriteLine("Loading from file...");

        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(_filename);

        //this needs to get the lines in and get them back in the journal
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        Console.ReadKey(true);
        return entries;
    }
}