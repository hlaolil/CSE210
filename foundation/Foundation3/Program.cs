using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 12, 3), 30, 4.8),
            new Cycling(new DateTime(2024, 12, 4), 45, 20),  
            new Swimming(new DateTime(2024, 12, 5), 40, 30)  
        };

      
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
