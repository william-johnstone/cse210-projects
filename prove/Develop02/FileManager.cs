public class FileManager
{
    public string _filename = "journal.txt";
    //public List<Entry> entries = new List<Entry>();

    public void FileSave()
    {
        
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {

            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry}|");
            }
        }
    }

    public void FileLoad()
    {
        Console.WriteLine("Loading from file...");
        string[] lines = System.IO.File.ReadAllLines(_filename);

        //this needs to get the lines in and get them back in the journal
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}