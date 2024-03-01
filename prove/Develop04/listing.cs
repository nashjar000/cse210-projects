using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

class ListActivity: Activities
{
    // prompts
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Start the activity
    public void StartActivity(int durationInSeconds)
    {

        // Generate a random prompt
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);

        CountdownAnimation(5); // Countdown for 5 seconds to begin thinking about the prompt

        // Start listing items
        Console.WriteLine("\nStart listing items:");

        // Store the prompt and items in a StringBuilder
        StringBuilder activityData = new StringBuilder();
        List<string> itemsList = new List<string>();

        // Timer info:
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInSeconds);

        // Loop until the end time is reached
        while (DateTime.Now < endTime) 
        {
            string item = Console.ReadLine(); // Read user input
            if (!string.IsNullOrEmpty(item)) // Check if the user entered an item
            {
                itemsList.Add(item); // Add the item to the list
            }
        }

        // Append the prompt and items to the StringBuilder
        activityData.AppendLine($"Prompt: {prompt}");
        activityData.AppendLine("Items:");
        foreach (var item in itemsList)
        {
            activityData.AppendLine(item);
        }

        // Save the prompt and items to a text file
        string fileName = "list_activity_items.txt";
        File.WriteAllText(fileName, activityData.ToString()); // Save StringBuilder content to file

        Console.WriteLine($"\nNumber of items entered: {itemsList.Count}"); // Display the number of items entered
        CommonMessages.DisplayEndingMessage("\nListing Activity", durationInSeconds); // Display ending message
    }

    private void CountdownAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);   // Print the number
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b"); // Overwrite the previous number
        }
        Console.WriteLine(); // Move to the next line after the countdown
    }
}