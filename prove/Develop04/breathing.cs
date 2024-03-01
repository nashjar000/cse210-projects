using System;

class BreathingActivity: Activities
{
    public void StartActivity(int duration)
    {

        for (int i = 0; i < duration; i++) // Loop for the duration of the activity
        {
            Console.WriteLine("Breathe in...");
            CountdownAnimation(4); // Countdown for 4 seconds
            Console.WriteLine("Breathe out...");
            CountdownAnimation(4); // Countdown for 4 seconds
        }

        CommonMessages.DisplayEndingMessage("\nBreathing Activity", duration);
        // Add a pause before finishing
    }
    
    private void CountdownAnimation(int seconds) // Countdown animation
    {
        for (int i = seconds; i > 0; i--) // Countdown from seconds
        {
            Console.Write($"{i}"); // Print the number
            System.Threading.Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b"); // Overwrite the previous number
        }
        Console.WriteLine(); // Move to the next line after the countdown
    }
}