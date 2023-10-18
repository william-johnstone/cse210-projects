class Reference
{
    public string ReferenceSource;
    private string _referenceBook;
    private string _referenceChapter;
    private string _referenceVerse;
    public string GetReference()
    {
        string[] referenceParts = ReferenceSource.Split(',');
        _referenceBook = referenceParts[0];
        _referenceChapter = referenceParts[1];
        _referenceVerse = referenceParts[2];
        return $"{_referenceBook} {_referenceChapter}:{_referenceVerse} ";
    }
}