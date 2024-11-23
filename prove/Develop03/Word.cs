public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor initializes the word text and hidden state
    public Word(string text, bool isHidden = false) // Default is not hidden
    {
        _text = text;
        _isHidden = isHidden;
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Shows the word (reveals it)
    public void Show()
    {
        _isHidden = false;
    }

    // Returns whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the word text or a placeholder if hidden
    public string GetDisplayText()
    {
        return _isHidden ? "____" : _text;
    } 
}