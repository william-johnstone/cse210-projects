class Reference
{
    //these are variables for the reference parts.  The source is public to use in Program.
    public string referenceSource;
    private string _referenceBook;
    private string _referenceChapter;
    private string _referenceVerse;
    //This returns the formatted Reference
    public string GetReference()
    {
        string[] referenceParts = referenceSource.Split(',');
        _referenceBook = referenceParts[0];
        _referenceChapter = referenceParts[1];
        _referenceVerse = referenceParts[2];
        return $"{_referenceBook} {_referenceChapter}:{_referenceVerse} ";
    }
}