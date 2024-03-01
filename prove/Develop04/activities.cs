using System;
using System.Threading;

// Activities class:
// This class contains methods to run and display various activities

class Activities
{
    // Run reflection activity
    // This method runs a reflection activity for a given duration
    public void RunReflectionActivity(int duration)
    {
        // Prepare to begin the activity
        CommonMessages.PrepareToBegin(duration); 
        // Start the reflection activity
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.StartActivity(duration);
        // Display ending message
        CommonMessages.DisplayEndingMessage("Reflection Activity", duration);
    }

    // Run breathing activity
    // This method runs a breathing activity for a given duration
    public void RunBreathingActivity(int duration)
    {
        // Prepare to begin the activity
        CommonMessages.PrepareToBegin(duration);
        // Start the breathing activity
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.StartActivity(duration);
        // Display ending message
        CommonMessages.DisplayEndingMessage("Breathing Activity", duration);
    }

    // Run list activity
    // This method runs a list activity for a given duration
    public void RunListActivity(int duration)
    {
        // Prepare to begin the activity
        CommonMessages.PrepareToBegin(duration);
        // Start the list activity
        ListActivity listActivity = new ListActivity();
        listActivity.StartActivity(duration);
        // Display ending message
        CommonMessages.DisplayEndingMessage("Listing Activity", duration);
    }

    // RUn the chosen activity
    // This method displays the starting message for the chosen activity
    public void DisplayActivityMessage(string activityName, string activityDescription)
    {
        Console.WriteLine($"Starting {activityName.ToLower()}");
        Console.WriteLine($"{activityName}:");
        CommonMessages.DisplayStartingMessage(activityName, activityDescription);
    }

    // Get activity duration
    // This method prompts the user to input the duration for the activity
    public int GetActivityDuration()
    {
        int duration;
        Console.Write("How long, in seconds, would you like for your activity? ");
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Invalid input. Please set the duration in seconds: ");
        }
        return duration;
    }
}

// CommonMessages class:
// This class contains methods to display common messages for activities
class CommonMessages
{
    // display common message
    // This method displays the starting message for the activity
    public static void DisplayStartingMessage(string activityName, string description)
    {
        // Welcome message
        Console.WriteLine($"Welcome to the {activityName}!");
        // Description
        Console.WriteLine(description);
    }

    // Prepare to begin
    // This method prepares for the activity to begin by displaying a message and a spinner
    public static void PrepareToBegin(int duration)
    {
        // Prepare to begin message
        Console.WriteLine("Get ready to begin...");

        // Add a spinner for 5 seconds
        var spinnerDuration = 5; // in seconds
        var spinnerTimer = new Timer((state) =>
        {
            var spinnerChars = new[] { '|', '/', '-', '\\' };
            var spinnerIndex = 0;
            Console.Write(" ");
            var spinnerTimer = new Timer((state) =>
            {
                Console.Write($"\b{spinnerChars[spinnerIndex]}");
                spinnerIndex = (spinnerIndex + 1) % spinnerChars.Length;
            }, null, 0, 250);

            Thread.Sleep(spinnerDuration * 1000);
            spinnerTimer.Dispose();
            Console.WriteLine("\b"); // clear the spinner
        }, null, 0, Timeout.Infinite);

        // Simulate the duration of the activity
        Thread.Sleep(duration * 1000); 
    }

    // Display ending message
    // This method displays the ending message for the activity
    public static void DisplayEndingMessage(string activityName, int duration)
    {
        // Good job message
        Console.WriteLine("Good job! You have completed the activity.");
        // display how long it took to do the activity 
        Console.WriteLine($"You have completed the {activityName} for {duration} seconds.");
    }
}