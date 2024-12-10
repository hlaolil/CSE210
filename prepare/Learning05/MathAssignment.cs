using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor
    public MathAssignment(string topic, string studentName, string textbookSection, string problems)
        : base(topic, studentName)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Properties
    public string TextbookSection
    {
        get { return _textbookSection; }
        set { _textbookSection = value; }
    }

    public string Problems
    {
        get { return _problems; }
        set { _problems = value; }
    }

    // Method to get homework list
    public string GetHomeworkList()
    {
        return $"Textbook Section: {TextbookSection}, Problems: {Problems}";
    }
}
