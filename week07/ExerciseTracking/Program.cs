using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // Running Activity
        Running runningActivity = new Running(30, 3.0f);
        runningActivity.Calculations();

        // Cycling Activity
        Cycling cyclingActivity = new Cycling(45, 12.0f);
        cyclingActivity.Calculations();

        // Swimming Activity
        Swimming swimmingActivity = new Swimming(30, 10.0f);
        swimmingActivity.Calculations();
    
        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine(activities[i].GetSummary());
        }
    }
}