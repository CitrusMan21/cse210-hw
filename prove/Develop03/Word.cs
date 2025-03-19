// Class to represent each word in the scripture and its hidden state
class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false; // Words start as visible
    } 

    public string GetWordString()
    {    
        return _hidden ? new string('_', _word.Length) : _word;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetOriginalWord()
    {
        return _word;
    }
}
