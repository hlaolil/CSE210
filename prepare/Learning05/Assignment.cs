using System;

class Assignment
{
    private string _topic;
    private string _studentName;

    // Constructor
    public Assignment(string topic, string studentName)
    {
        _topic = topic;
        _studentName = studentName;
    }

    // Properties
    public string Name
    {
        get { return _studentName; }
        set { _studentName = value; }
    }

    public string Topic
    {
        get { return _topic; }
        set { _topic = value; }
    }

    // Method to get a summary
    public string GetSummary()
    {
        return $"Student: {Name}, Topic: {Topic}";
    }
}
