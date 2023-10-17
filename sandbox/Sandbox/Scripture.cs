class Scripture
{
    //this variable could be used to create a custom file
    private string _filename = "scriptures.txt";
    //used to help get the lines information
    private string[] _fileContent;
    //setter getter for the full book chapter verse
    private string ScriptureSource
    {
        set; get;
    }
    //setter getter for the scripture text from Reference
    public Word ScriptureText
        {
            private set; get;
        }
    //setter getter for Book
    public string ScriptureBook
        {
            private set; get;
        }
    
    public string ScriptureChapter
        {
            private set; get;
        }
    public string ScriptureVerse
        {
            private set; get;
        }
    public string OriginalScriptureFormat
    {
        private set; get;
    }

    private void ReadFile()
    {
        _fileContent = File.ReadAllLines(_filename);
    }

    public void ScriptureLoad()
    {
        ReadFile();
        int _lineScripture = new Random().Next(0, _fileContent.Count());
        string line = _fileContent[_lineScripture].Replace("\"", "");
        string[] lineParts = line.Split('|');
        ScriptureSource = lineParts[0];
        ScriptureText = new Word(lineParts[1]);
        string[] sourceParts = ScriptureSource.Split(',');
        ScriptureBook = sourceParts[0];
        ScriptureChapter = sourceParts[1];
        ScriptureVerse = sourceParts[2];
        OriginalScriptureFormat = $"{ScriptureBook} {ScriptureChapter}:{ScriptureVerse} {ScriptureText.WholeScripture}";
    }

    //This method can be called to get a consistent format with the ScriptureText.ModifiedScripture method using the Reference object
    public string ModifiedScripture
    {
        get
        {
            return $"{ScriptureBook} {ScriptureChapter}:{ScriptureVerse} {ScriptureText.ModifiedScripture}";
        }
    }

    public bool Complete
    {
        get
        {
            return ScriptureText.Complete;
        }
    }  
}