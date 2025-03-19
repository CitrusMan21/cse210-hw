class Scripture
{
    private Referance _referance;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Referance referance, string text)
    {
        _referance = referance;
        _words = new List<Word>();

        // Split the scripture text into words and store them as Word objects
        string[] scriptureWords = text.Split(' ');
        foreach (string w in scriptureWords)
        {
            _words.Add(new Word(w));
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"\n{_referance.DisplayReferance()}");
        
        foreach (Word w in _words)
        {
            Console.Write($"{w.GetWordString()} ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0) return; // Prevent errors when all words are hidden

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].HideWord();
            visibleWords.RemoveAt(index); // Remove from list to avoid selecting again
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public double GradeUserInput(string userInput)
    {
        string[] userWords = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string[] originalWords = _words.Select(w => w.GetOriginalWord()).ToArray();

        int correctCount = 0;
        int totalWords = originalWords.Length;

        for (int i = 0; i < Math.Min(userWords.Length, totalWords); i++)
        {
            if (userWords[i].Equals(originalWords[i], StringComparison.OrdinalIgnoreCase))
            {
                correctCount++;
            }
        }

        return ((double)correctCount / totalWords) * 100;
    }
}