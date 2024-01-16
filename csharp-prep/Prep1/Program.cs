using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first name
        Console.Write("What is your first name? ");
        // Add first name to string
        string firstName = Console.ReadLine();

        // Ask the user for their last name
        Console.Write("What is your last name? ");
        // Add last name to string
        string lastName = Console.ReadLine();

        // Print out the James Bond message :)
        // String interpolation:
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

        // String formatting (common in other languages, but, not for this course)
        // Console.WriteLine("Your name is {0}, {1} {0}", lastName, firstName);

    }
}