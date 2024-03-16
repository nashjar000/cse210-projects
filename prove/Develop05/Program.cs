using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // clear the console
        Console.Clear();

        // create a list of goals
        bool quit = false;
        List<Goal> goals = new List<Goal>();

        // display the menu options
        while (!quit)
        {
            // display the user's points
            int totalPoints = goals.Where(g => g.IsCompleted()).Sum(g => g.Points);
            Console.WriteLine($"\nYou have {totalPoints} points.");

            // display the menu options
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            // get the user's choice
            Console.Write("\nSelect a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    // create a new goal
                    case 1:
                        CreateNewGoal(goals);
                        break;
                    // list the goals
                    case 2:
                        ListGoals(goals);
                        break;
                    // save the goals
                    case 3:
                        Console.Write("Enter the file name to save: ");
                        string saveFileName = Console.ReadLine();
                        SaveGoals(goals, saveFileName);
                        break;
                    // load the goals
                    case 4:
                        Console.Write("Enter the file name to load: ");
                        string loadFileName = Console.ReadLine();
                        goals = LoadGoals(loadFileName);
                        break;
                    // record an event
                    case 5:
                        Console.Write("Enter the index of the goal to record an event: ");
                        if (int.TryParse(Console.ReadLine(), out int goalIndex))
                        {
                            RecordEvent(goals, goalIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid goal index.");
                        }
                        break;
                    // quit
                    case 6:
                        quit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    // invalid choice
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            // invalid input
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    
static void CreateNewGoal(List<Goal> goals)
{
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    
    Console.Write("\nWhich type of goal would you like to create: ");
    
    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.Write("\nWhat is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        switch (choice)
        {
            case 1:
                Console.Write("What is the amount of points associated with this goal: ");
                if (int.TryParse(Console.ReadLine(), out int simpleGoalPoints))
                {
                    goals.Add(new SimpleGoal(goalName, goalDescription, simpleGoalPoints));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for points.");
                }
                break;

            case 2:
                Console.Write("Enter the points for each event: ");
                if (int.TryParse(Console.ReadLine(), out int eternalPoints))
                {
                    goals.Add(new EternalGoal(goalName, eternalPoints, goalDescription));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for points.");
                }
                break;

            case 3:
                Console.Write("What is the amount of points associated with this goal? ");
                if (int.TryParse(Console.ReadLine(), out int checklistPoints))
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    if (int.TryParse(Console.ReadLine(), out int checklistAccomplishCount))
                    {
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        if (int.TryParse(Console.ReadLine(), out int checklistBonus))
                        {
                            goals.Add(new ChecklistGoal(goalName, goalDescription, checklistPoints, checklistAccomplishCount, checklistBonus));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number for the bonus amount.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for the checklist target count.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for points.");
                }
                break;

            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}

static void ListGoals(List<Goal> goals)
{
    for (int i = 0; i < goals.Count; i++)
    {
        var goal = goals[i];
        string completionStatus = goal.IsCompleted() ? "x" : " ";
        
        if (goal is ChecklistGoal checklistGoal)
        {
            Console.WriteLine($"{i + 1}. [{completionStatus}] {checklistGoal.Name} ({checklistGoal.Description}) - Currently completed: {checklistGoal.CompletedCount}/{checklistGoal.TargetCount}");
        }
        else
        {
            Console.WriteLine($"{i + 1}. [{completionStatus}] {goal.Name} ({goal.Description})");
        }
    }
}


   static void SaveGoals(List<Goal> goals, string fileName)
{
    using (StreamWriter writer = new StreamWriter(fileName))
    {
        // Calculate total points earned from all goals
        int totalPoints = goals.Sum(g => g.Points);
        writer.WriteLine(totalPoints); // Write total points as the first line

        foreach (var goal in goals)
        {
            string goalLine = "";

            if (goal is SimpleGoal simpleGoal)
            {
                goalLine = $"SimpleGoal: {simpleGoal.Name}, {simpleGoal.Description}, {simpleGoal.Points}, False";
            }
            else if (goal is EternalGoal eternalGoal)
            {
                goalLine = $"EternalGoal: {eternalGoal.Name}, {eternalGoal.Description}, {eternalGoal.Points}";
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                goalLine = $"ChecklistGoal: {checklistGoal.Name}, {checklistGoal.Description}, {checklistGoal.Points},{checklistGoal.TargetCount},{checklistGoal.Bonus}";
            }

            writer.WriteLine(goalLine);
        }
    }

    Console.WriteLine("Goals saved successfully.");
}

static List<Goal> LoadGoals(string fileName)
{
    List<Goal> loadedGoals = new List<Goal>();

    using (StreamReader reader = new StreamReader(fileName))
    {
        string line;
        int totalPoints = 0;
        bool isFirstLine = true;

        while ((line = reader.ReadLine()) != null)
        {
            if (isFirstLine)
            {
                isFirstLine = false;
                totalPoints = int.Parse(line); // Read total points from the first line
                continue; // Skip to the next line
            }

            string[] parts = line.Split(':');
            string[] parameters = parts[1].Split(',');

            string name = parameters[0].Trim();
            string description = parameters[1].Trim();
            int points = int.Parse(parameters[2].Trim());

            if (parts[0] == "SimpleGoal")
            {
                bool isCompleted = bool.Parse(parameters[3].Trim());
                loadedGoals.Add(new SimpleGoal(name, description, points, isCompleted));
            }
            else if (parts[0] == "EternalGoal")
            {
                loadedGoals.Add(new EternalGoal(name, points, description));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                int targetCount = int.Parse(parameters[3].Trim());
                int bonus = int.Parse(parameters[4].Trim());
                loadedGoals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
            }

        }
    }

    Console.WriteLine("Goals loaded successfully.");
    return loadedGoals;
}



static void RecordEvent(List<Goal> goals, int goalIndex)
{
    // Adjust the index to match the zero-based index in the list
    goalIndex -= 1;

    if (goalIndex >= 0 && goalIndex < goals.Count)
    {
        goals[goalIndex].RecordEvent();
        Console.WriteLine("Event recorded for the goal: " + goals[goalIndex].Name);
    }
    else
    {
        Console.WriteLine("Invalid goal index. Please enter a valid goal index.");
    }
}
}