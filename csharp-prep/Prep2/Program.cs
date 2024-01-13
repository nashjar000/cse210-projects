using System;

class Program
{
    static void Main(string[] args)
    {
    // Ask the user for their grade percentage
        Console.WriteLine("What is your grade percentage? ");
    // Add grade percentage to string
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);
        string grade = "";

    // Determine the letter grade (if/elif/else)
        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else
        {
            grade = "F";
        }
    // Print out the letter grade
        Console.WriteLine($"Your grade is: {grade}");

    // Print out message based on letter grade
    // 70% or better:
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course! :)");
        }
    // Otherwise:
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Try again.");
        }
    }
}