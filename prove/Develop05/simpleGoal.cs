class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    // Constructor with isCompleted parameter
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"\n{Name} completed! You gained {Points} points.");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"{(_isCompleted ? "[x]" : "[ ]")} {Name}");
    }

    // Implement the IsCompleted method
    public override bool IsCompleted()
    {
        return _isCompleted;
    }
}
