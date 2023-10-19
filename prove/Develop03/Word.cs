class Word
{
    //This class needs to look at a word and change it to underscores or know if it already has been
    public string evalWord
    {
        private set; get;
    }
    public Word(string word)
    {
        evalWord = word;
    }
    public void ChangeToUnderscore()
    {
        string underscores = "";
        foreach (char letter in evalWord)
        {
            underscores += "_";
        }
        evalWord = underscores;
    }
    public bool IsWordModified()
    {
        return evalWord[0]=='_';
    }
}