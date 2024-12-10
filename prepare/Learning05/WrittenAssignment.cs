using System;


class WrittenAssignment : Assignment
{
    private string _title;

    // Constructor
    public WrittenAssignment(string topic, string studentName, string title)
        : base(topic, studentName)
    {
        _title = title;
    }

    // Properties
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    // Method to get writing info
    public string GetWritingInfo()
    {
        return $"Title: {Title}";
    }
}
