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

    public void FileLoad()
    {
        //string _filename = "journal.txt";
        Console.WriteLine("Loading from file...");

        string[] lines = System.IO.File.ReadAllLines(_filename);

        //this needs to get the lines in and get them back in the journal
        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            string[] p1 = line.Split('|');
            //this if checks for valid entries that have both a date and a content
            if (p1.Count()==2)
            {
                Entry one = new Entry();
                one.entryDate=p1[0].Trim();
                one.entryContent=p1[1].Trim();
                entries.Add(one);
                //entries.Add(new Entry{entryDate=p1[0].Trim(), entryContent=p1[1].Trim()});
            }                
        }
        //Console.ReadKey(true);
    }
}