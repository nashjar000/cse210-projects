using System;
using System.Collections.Generic;

/*
Class: Job
Responsibilities:
Keeps track of the company, job title, start year, and end year.
Behaviors:
Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
*/
public class Job
{
    public string _Company { get; set; }
    public string _JobTitle { get; set; }
    public int _StartYear { get; set; }
    public int _EndYear { get; set; }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title: {_JobTitle}");
        Console.WriteLine($"Company: {_Company}");
        Console.WriteLine($"Start Year: {_StartYear}");
        Console.WriteLine($"End Year: {_EndYear}");
    }
}
