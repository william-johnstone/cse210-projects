public class FileManager
{
    public string _filename = "journal.txt";
    public List<Entry> entries = new List<Entry>();

    public void FileSave()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public void FileLoad()
    {
        //a;lkjadsf;l
    }
}