using System;
using System.Collections.Generic;

public class Resume
{
    private string _name;
    private List<Job> _jobList;

    // Constructor
    public Resume(string name, List<Job> jobList)
    {
        _name = name;
        _jobList = jobList;
    }

    // Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public List<Job> JobList
    {
        get { return _jobList; }
        set { _jobList = value; }
    }

    // Method to display work experience
    public void WorkExperience()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        
        foreach (var job in JobList)
        {
            job.JobInfo();
        }
    }
}