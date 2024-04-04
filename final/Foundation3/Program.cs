using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Addresses:
        // Create addresses
        Address address1 = new Address("543 Main St", "Cityville", "CO", "12345");
        Address address2 = new Address("321 Elm St", "Townsville", "ID", "67890");
        Address address3 = new Address("123 Oak St", "Villageton", "WA", "54321");

        // Create events:
        // Lecture: Title, Description, Date, Time, Address, Speaker, Capacity
        Event lecture = new Lecture("How to Hide Ducks in your Apartment", "Come learn how to hide ducks in your apartment with a professional duck hider!", new DateTime(2024, 3, 20), TimeSpan.FromHours(10), address1, "The Duck", 42);
        
        // Reception: Title, Description, Date, Time, Address, RSVP email
        Event reception = new Reception("Wedding Reception", "Come to Mr. & Mrs. Smith's wedding!", new DateTime(2024, 4, 15), new TimeSpan(18, 0, 0), address2, "rsvp@fakemail.com");
        
        // Outdoor Gathering: Title, Description, Date, Time, Address, Weather
        Event outdoorGathering = new OutdoorGathering("Picnic in the Park", "Casual gathering for fun and games", new DateTime(2024, 5, 1), new TimeSpan(12, 0, 0), address3, "Rainy");
    

        // Marketing message:
        Console.WriteLine("Marketing Messages:");
        Console.WriteLine("--------------------");

        Console.WriteLine("Lecture:");
        // Use "hh" format specifier to display the time in 12-hour format
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();


        Console.WriteLine("Reception:");
        // Use "hh" format specifier to display the time in 12-hour format
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        // Use "hh" format specifier to display the time in 12-hour format
        Console.WriteLine(outdoorGathering.GetFullDetails());
    }
}


