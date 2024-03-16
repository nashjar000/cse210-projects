class SimpleGoal : Goal
{
    // the private bool is used to track whether the goal has been completed
    private bool _completed;

    // the private string is used to store the description of the goal
    public SimpleGoal(string name, string description, int points) : base(name)
    {
        _completed = false;
        _description = description;
        _points = points;
    }

    // record event
    public override void RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"\n{_name} completed! You earned {_points} points.");
        Console.WriteLine($"Here's how you defined your goal: {_description}");
    }

    // display progress 
    public override void DisplayProgress()
    {
        Console.WriteLine($"[{(_completed ? 'X' : ' ')}] ({Description})");
    }
}