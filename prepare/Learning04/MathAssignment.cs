using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Math assignment--includes name, topic, and textbook section
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Get homework list and return it textbook section - problems
    public string GetHomeworkList(){
        return $"{_textbookSection} - {_problems}";
    }

}