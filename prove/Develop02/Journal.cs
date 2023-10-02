public class Journal
{
    public List<Entry> entries = new List<Entry>();
    
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.ViewEntry();
        }
    }
}