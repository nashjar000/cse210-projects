using System;

class Program
{
static void Main()
{
    // Job 1 
    Job job1 = new Job();
    // Job title
    job1._JobTitle = "Software Engineer";
    // Company
    job1._Company = "Microsoft";
    // Start & end year
    job1._StartYear = 2019;
    job1._EndYear = 2022;

    // Job 2
    Job job2 = new Job();
    // Job title
    job2._JobTitle = "Manager";
    // Company
    job2._Company = "Apple";
    // Start & end year
    job2._StartYear = 2022;
    job2._EndYear = 2023;

    // Resume
    Resume myResume = new Resume();
    // Name
    myResume.PersonName = "Perry the Platypus";
    
    // Add jobs
    myResume.Jobs.Add(job1);
    myResume.Jobs.Add(job2);

    // Display resume
    myResume.DisplayResume();
}
}