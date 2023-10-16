using System;

class Reference
{
    private string[] _scriptureText;
    private List<int> _modWords = new List<int>();
    public Reference(string scriptureText)
    {
        _scriptureText = scriptureText.Split(" ");
    }

    public string WholeScripture
    {
        get
        {
            return string.Join(" ", _scriptureText);
        }
    }
    
    public string ModifiedScripture
    {
        get
        {
            Random rnd = new Random();
            int hide = rnd.Next(3, 5);
            for (int x = 0; x < hide; x++)
            {
                int word;
                if (_modWords.Count() >= _scriptureText.Count())
                {
                    break;
                }
                do
                {
                    word = rnd.Next(_scriptureText.Count());
                }
                while (_modWords.Contains(word));
                _modWords.Add(word);

                _scriptureText[word] = new string('_', _scriptureText[word].Length);
            }
            return string.Join(" ", _scriptureText);
        }
    }

    public bool Complete
    {
        get
        {
            return _modWords.Count() >= _scriptureText.Count();
        }
    }

}