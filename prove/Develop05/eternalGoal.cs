public class EternalGoal : Goal
{
    private int _pointsPerEvent;

    public EternalGoal(string name, int pointsPerEvent, string description) : base(name)
    {
        _pointsPerEvent = pointsPerEvent;
        _description = description;
    }

    public override void RecordEvent()
    {
        // Mark the goal as completed
        _isCompleted = true;

        Console.WriteLine($"{Name} completed! You earned {_pointsPerEvent} points.");
    }


    public override void DisplayProgress()
    {
        Console.WriteLine($"{Name}: {_description}");
    }

    public override bool IsCompleted()
    {
        return false; // Eternal goals are never completed
    }
}
