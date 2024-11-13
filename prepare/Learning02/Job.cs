public class Job
{
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    // Constructor
    public Job(string company, string title, int start, int end)
    {
        _company = company;
        _jobTitle = title;
        _startYear = start;
        _endYear = end;
    }

    // Properties
    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }

    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    public int StartYear
    {
        get { return _startYear; }
        set { _startYear = value; }
    }

    public int EndYear
    {
        get { return _endYear; }
        set { _endYear = value; }
    }

    // Method to display job information
    public void JobInfo()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}
