

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;


    // Constructor
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Public properties for accessing private fields
    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string PromptText
    {
        get { return _promptText; }
        set { _promptText = value; }
    }

    public string EntryText
    {
        get { return _entryText; }
        set { _entryText = value; }
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}\n");
    }

}


