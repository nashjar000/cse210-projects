class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) : base(name)
    {
        _description = description;
        _targetCount = targetCount;
        _bonus = bonus;
        Points = points; // Initialize the Points property in the base class
        _completedCount = 0; // Initialize the completed count
    }

    // Record an event for the checklist goal
    public override void RecordEvent()
    {
        // Increment the completed count
        _completedCount++;
        Console.WriteLine($"\n{Name} completed! You gained {Points} points.");

        // Check if the goal is completed
        if (_completedCount == _targetCount)
        {
            Points += _bonus; // Bonus points for completing the checklist
            Console.WriteLine($"Bonus! Goal {Name} completed {_completedCount}/{_targetCount} times. You gained an additional {_bonus} points.");
        }
    }

    // Display the progress of the checklist goal
    public override void DisplayProgress()
    {
        Console.WriteLine($"[{_completedCount}/{_targetCount}] {Name}");
    }

    public override bool IsCompleted()
    {
        return _completedCount == _targetCount; // Return true if the completed count equals the target count
    }

    public int TargetCount
    {
        get { return _targetCount; }
    }

    public int CompletedCount
    {
        get { return _completedCount; }
    }

    public int Bonus
    {
        get { return _bonus; }
        set { _bonus = value; }
    }
}
