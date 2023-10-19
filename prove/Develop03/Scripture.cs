class Scripture
{
    public string scriptureSource;
    private static List<Word> originalWords = new List<Word>();
    private List<Word> modifiedWords = new List<Word>();

    public void ParseScriptureSource()
    {
        string[] individualWords = scriptureSource.Split(" ");
        foreach (string individualWord in individualWords)
        {
            Word wordmod = new Word(individualWord);
            Word wordorig = new Word(individualWord);
            modifiedWords.Add(wordmod);
            originalWords.Add(wordorig);
        }
    }

    public void ChangeWords()
    {
        Random rnd = new Random();
        //change between 2 and 5 words
        int hide = rnd.Next(2, 5);
        //this loop makes sure that there are more words to hide from the rnd and also that not all words are hidden
        while (hide != 0 && !IsComplete()) 
        {
            ChangeSingleWord();
            hide--;
        }        
    }
    private void ChangeSingleWord()
    {
        List<int> unchangedModifiedIndex = new List<int>();
        for (int i=0; i < modifiedWords.Count(); i++)
        {
            if (!modifiedWords[i].IsWordModified())
            {
                unchangedModifiedIndex.Add(i);
            }
        }
        Random rnd = new Random();
        int iWord = rnd.Next(0, unchangedModifiedIndex.Count());
        if (unchangedModifiedIndex.Count()!=0)
        {
            int newiWord = unchangedModifiedIndex[iWord];
            modifiedWords[newiWord].ChangeToUnderscore();
        }
    }

    public bool IsComplete()
    {
        int totalDiff = 0;
        for (int i = 0; i < originalWords.Count(); i++)
        {
            if (originalWords[i].evalWord != modifiedWords[i].evalWord)
            {
                totalDiff++;
            }
        }
        return totalDiff==originalWords.Count();
    }

    public string GetModified()
    {
        string completeScripture = "";
        foreach (Word word in modifiedWords)
        {
            //build my string of words with spaces
            completeScripture += word.evalWord + " ";
        }
        return completeScripture;
    }
}