using System;
using System.Collections.Generic;


public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < Duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(6);
            Console.WriteLine("Breathe out...");
            ShowSpinner(6);
        }
        DisplayEndingMessage();
    }
}
