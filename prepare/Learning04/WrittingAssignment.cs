using System;

public class WrittingAssignment : Assignment
{
    private string _title; // gets the private string called _title

    // writing assignment--includes name, topic, and title
    public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic) 
    {
        _title = title;
    }

    // Get title and return it
    public string GetTitle(){
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}