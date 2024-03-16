class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points) : base(name)
    {
        _description = description;
        _points = points;
        _completed = false; // Simple goals start as incomplete
    }

    public override void RecordEvent()
    {
        _completed = true; // Mark the goal as completed when an event is recorded
        Console.WriteLine($"\n{_name} completed! You earned {_points} points.");
        Console.WriteLine($"Here's how you defined your goal: {_description}");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{(_completed ? 'X' : ' ')}] ({Description})");
    }

    public override bool IsCompleted()
    {
        return _completed; // Return the completion status of the goal
    }
}
