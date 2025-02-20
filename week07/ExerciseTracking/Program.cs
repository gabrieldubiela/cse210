using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> _activities = new List<Activity>();
        Activity cycling = new Cycling("Cycling", new DateTime(2025, 2, 19), 60, 4);
        _activities.Add(cycling);
        Activity running = new Running("Running", new DateTime(2025, 2, 20), 30, 1);
        _activities.Add(running);
        Activity swimming = new Swimming("Swimming", new DateTime(2025, 2, 21), 45, 1);
        _activities.Add(swimming);
        foreach (Activity activity in _activities)
        {
            activity.Calculate();
            activity.GetSummary();
        }
    }
}