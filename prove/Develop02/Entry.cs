public class Entry
{
    public string entryDate;
    public string entryContent;

    //AddEntry takes the user input for the Entry while also saving the date
    public void AddEntry()
    {
        entryDate = DateTime.Now.ToString("M/d/yyyy");
        Console.Write("Entry= ");
        entryContent = Console.ReadLine();
    }
    public void ViewEntry()
    {
        Console.WriteLine($"{entryDate} | {entryContent}");
    }
}