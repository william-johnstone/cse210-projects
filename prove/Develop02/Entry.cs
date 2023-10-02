public class Entry
{
    public string entryDate;
    public string entryContent;
    public string entryWhole;

    public void AddEntry()
    {
        entryDate = DateTime.Now.ToString("mm/dd/yyyy");
        Console.Write("Entry= ");
        entryContent = Console.ReadLine();
        entryWhole = entryDate + "-" + entryContent;
    }
    public void ViewEntry()
    {
        Console.WriteLine($"{entryDate} - {entryContent}");
    }
}