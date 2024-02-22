using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Assignment--includes name and topic
    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    // Get name and return it
    public string GetStudentName(){
        return _studentName;
    }

    // Get topic and return it
    public string GetTopic(){
        return _topic;
    }

    // Get summary and return it Student name - Topic
    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
}