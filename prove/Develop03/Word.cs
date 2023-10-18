class Word
{
    public string EvalWord
    {
        private set; get;
    }
    public Word(string word)
    {
        EvalWord = word;
    }
    public void ChangeToUnderscore()
    {
        string underscores = "";
        foreach (char letter in EvalWord)
        {
            underscores += "_";
        }
        EvalWord = underscores;
    }
    public bool IsWordModified()
    {
        return EvalWord[0]=='_';
    }
}