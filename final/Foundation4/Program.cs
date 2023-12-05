using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();
        // Creating activities | date, duration, (run=distance/cyc=distance/swim=laps)
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now.AddDays(-5), 30, 4.1),
            new Cycling(DateTime.Now.AddDays(-4), 45, 30.3),
            new Swimming(DateTime.Now.AddDays(-3), 72, 55),
            new Running(DateTime.Now.AddDays(-2), 30, 3.0), 
            new Cycling(DateTime.Now.AddDays(-1), 30, 4.8),
            new Swimming(DateTime.Now.AddDays(0), 33, 50)
        };

        Console.WriteLine("Activity Results:");
        // Displaying summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
