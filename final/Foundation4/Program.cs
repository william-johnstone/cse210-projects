using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating activities
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now.AddDays(-2), 30, 3.0),
            new Cycling(DateTime.Now.AddDays(-1), 45, 25.0),
            new Swimming(DateTime.Now, 40, 20)
        };

        // Displaying summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
