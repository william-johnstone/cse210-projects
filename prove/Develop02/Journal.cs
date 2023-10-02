public class Journal
{
    public List<Entry> entry = new List<Entry>();
    
    public void DisplayEntries()
    {
        foreach (Entry entry in entry)
        {
            entry.ViewEntry();
        }
    }
}