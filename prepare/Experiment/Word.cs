class Word
{
    //an array of the scripture text
    private string[] _scriptureText;
    //the list of words that will be used when we start hiding things
    private List<int> _modWords = new List<int>();
    public Word(string scriptureText)
    {
        _scriptureText = scriptureText.Split(" ");
    }

    //a getter to put the words back into a string with spaces
    public string WholeScripture
    {
        get
        {
            return string.Join(" ", _scriptureText);
        }
    }
    
    //a getter for modifying the words of the scripture text
    public string ModifiedScripture
    {
        get
        {
            //create random object and get a random number for hiding words
            Random rnd = new Random();
            int hide = rnd.Next(3, 5);
            //loop for hiding words
            for (int x = 0; x < hide; x++)
            {
                int word;
                //if the count of words that have been "hidden" is equal or greater then exit to prevent an infinite loop
                if (_modWords.Count() >= _scriptureText.Count())
                {
                    break;
                }
                //a do while loop to get the random word to hide, will always go until the list is full 
                do
                {
                    word = rnd.Next(_scriptureText.Count());
                }
                while (_modWords.Contains(word));
                //add the hidden word to the list
                _modWords.Add(word);
                //change the word to underscores based on the legnth of the word
                _scriptureText[word] = new string('_', _scriptureText[word].Length);
            }
            //return the words together with a space between, including the words changed to underscore
            return string.Join(" ", _scriptureText);
        }
    }

    //this method is a true or false to see if there are more words that can be hidden
    public bool Complete
    {
        get
        {
            return _modWords.Count() >= _scriptureText.Count();
        }
    }

}