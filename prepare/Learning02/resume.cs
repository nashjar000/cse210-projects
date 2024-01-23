using System;
/*
Class: Resume
Responsibilities:
Keeps track of the person's name and a list of their jobs.
Behaviors:
Displays the resume, which shows the name first, followed by displaying each one of the jobs.
*/ 

public class Resume
{
    public string PersonName { get; set; }
    public List<Job> Jobs { get; set; }

    public Resume()
    {
        Jobs = new List<Job>();
    }

    public void DisplayResume()
    {
Console.WriteLine($"Name: {PersonName}");
    Console.WriteLine("Jobs:");
    foreach (Job job in Jobs)
    {
        Console.WriteLine($"{job._JobTitle} ({job._Company}) {job._StartYear}-{job._EndYear}");
    }
    }
}
