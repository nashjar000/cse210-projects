using System;

class Program
{
    static void Main()
    {
        // Display the main menu
        Console.WriteLine("Welcome to the Activity Menu!");
        Console.WriteLine("1. Start Reflection Activity");
        Console.WriteLine("2. Start Breathing Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("0. Quit");
        Console.Write("Choose an activity (1-3) or 0 to quit: ");

        // Get the user's choice
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 3)
        {
            Console.Write("Invalid input. Please choose an activity (1-3): ");
        }

        // Quit if user chooses 0
        if (choice == 0)
        {
            Console.WriteLine("Goodbye!");
            return;
        }

        // Run the activities
        Activities activities = new Activities();
        string activityName = "";
        string activityDescription = "";
        int activityDuration;

        // Set the activity name and description based on the user's choice
        // In the future, I would try to adjust this so that the name and description don't need to be here to limit redundancy
        switch (choice)
        {
            case 1:
                activityName = "Reflection Activity";
                activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
                break;
            case 2:
                activityName = "Breathing Activity";
                activityDescription = "This activity will help you relax and focus on your breathing to reduce stress and anxiety. It can also help improve your concentration and mindfulness.";
                break;
            case 3:
                activityName = "Listing Activity";
                activityDescription = "This activity will help you organize your thoughts and tasks by creating a list of things you need to do or remember. It can help reduce stress and improve productivity.";
                break;
        }

 // Run the chosen activity
activities.DisplayActivityMessage(activityName, activityDescription);
activityDuration = activities.GetActivityDuration();
        
        switch (choice)
        {
        // Reflection Activity
           case 1:
                activities.RunReflectionActivity(activityDuration);
                break;

        // Breathing Activity
            case 2:
                activities.RunBreathingActivity(activityDuration);
                break;

        // List Activity
            case 3:
                activities.RunListActivity(activityDuration);
                break;
        }
    }
}