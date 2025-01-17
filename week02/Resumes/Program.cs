using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._title = "Software Developer";
        job1._description = "Responsible for designing, implementing, and maintaining software applications.";
        job1._company = "Microsoft";

        Job job2 = new Job();
        job2._title = "Data Analyst";
        job2._description = "Analyze data to provide business insights.";
        job2._company = "Google";
        
        Resume johnDoe = new Resume();
        johnDoe._name = "John Doe";
        johnDoe._job.Add(job1);
        johnDoe._job.Add(job1);

        johnDoe.DisplayJobDetails();
    }
}