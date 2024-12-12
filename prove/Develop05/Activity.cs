using System;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting: {_name}\n{_description}\nDuration: {_duration} seconds");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending: {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|\b/\b-\b\\\b");
            System.Threading.Thread.Sleep(250);
        }
        Console.WriteLine();
    }

}
