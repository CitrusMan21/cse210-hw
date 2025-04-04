class Referance
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Referance(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    
    public string DisplayReferance()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}

