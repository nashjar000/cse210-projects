using System;
using System.Threading;
using System.Collections.Generic;

class ReflectionActivity: Activities
{
    // Prompts
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // reflection questions
    private List<string> reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Start the activity:
    public void StartActivity(int durationInSeconds)
    {

        // Generate a random prompt
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);

        CountdownAnimation(5); // Countdown for 5 seconds to begin reflecting on the prompt

      // Start the reflection questions
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInSeconds);

    // Start the reflection questions:
    while (DateTime.Now < endTime)
    {
        // Display the reflection questions
        SpinnerAnimation(5); // Spinner animation for 5 seconds
        // Generate a random reflection question
        string question = reflectionQuestions[random.Next(reflectionQuestions.Count)];
        // Display the reflection question
        Console.WriteLine(question);

        // Pause for 3 seconds
        Thread.Sleep(3000); // Pause for 3 seconds between each question
    }

    // Display ending message
    CommonMessages.DisplayEndingMessage("\nReflection Activity", durationInSeconds);
    }

    // Countdown animation:
    private void CountdownAnimation(int seconds) 
    {
        for (int i = seconds; i > 0; i--)   // Countdown from seconds to 0
        {
            Console.Write(i);   // Print the number
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b"); // Overwrite the previous number
        }
        Console.WriteLine(); // Move to the next line after the countdown
    }

    // Spinner animation:
    private void SpinnerAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250); // Pause for 250 milliseconds
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back
            index = (index + 1) % spinner.Length;
        }
        Console.WriteLine(" "); // Clear the spinner after animation
    }
}