using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8), // Distance in km
            new Cycling(new DateTime(2022, 11, 4), 45, 20),  // Speed in kph
            new Swimming(new DateTime(2022, 11, 5), 40, 30)  // Laps
        };

      
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
