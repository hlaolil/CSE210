public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse; // Nullable for optional endVerse

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    // Constructor for verse range
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Override ToString to return the formatted display text
    public override string ToString()
    {
        return GetDisplayText();  // Reusing existing method
    }

    // Method to return formatted reference text
    public string GetDisplayText()
    {
        if (_endVerse == null)
        {
            // Single verse format: Book Chapter:Verse
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Multi-verse format: Book Chapter:Verse-EndVerse
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
