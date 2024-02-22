using System;

class Program
{
    static void Main(string[] args)
    {
        // // create an assignment... student name, topic
        // Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        // Console.WriteLine(a1.GetSummary());

        // // create a math assignment... student name, topic, textbook section, problems
        // MathAssignment a2 = new MathAssignment("Roberto Carlos", "Fractions", "Section 7.3", "8-19");
        // Console.WriteLine(a2.GetSummary());
        // Console.WriteLine(a2.GetHomeworkList());

        // create a writting assignment... student name, topic, title
        WrittingAssignment a3 = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetTitle());
    }
}