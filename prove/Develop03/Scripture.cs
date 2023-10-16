using System;

class Scripture
{
    private string _filename = "scriptures.txt";
    private string[] _fileContent;
    private string ScriptureSource
    {
        set; get;
    }
    public Reference ScriptureText
        {
            private set; get;
        }
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
    public string ScriptureFormatted
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
        //Console.WriteLine(_fileContent.Count());
        int _lineScripture = new Random().Next(0, _fileContent.Count());
        string line = _fileContent[_lineScripture].Replace("\"", "");
        string[] lineParts = line.Split('|');
        ScriptureSource = lineParts[0];
        ScriptureText = new Reference(lineParts[1]);
        string[] sourceParts = ScriptureSource.Split(',');
        ScriptureBook = sourceParts[0];
        ScriptureChapter = sourceParts[1];
        ScriptureVerse = sourceParts[2];
        ScriptureFormatted = $"{ScriptureBook} {ScriptureChapter}:{ScriptureVerse} {ScriptureText.WholeScripture}";
    }

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