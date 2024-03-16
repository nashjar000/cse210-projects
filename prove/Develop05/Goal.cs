abstract class Goal
{
    protected string _name;
    protected int _points;
    protected string _description;
    protected bool _isCompleted;

    public Goal(string name)
    {
        _name = name;
        _points = 0;
        _description = "";
    }

    // Constructor with three arguments
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    // Constructor with two arguments
    public Goal(string name, int points) : this(name, "", points)
    {
    }

    public string Name
    {
        get { return _name; }
    }

    public string Description
    {
        get { return _description; }
    }

    public int Points
    {
        get { return _points; }
        protected set { _points = value; }
    }

    // Record an event for the goal
    public abstract void RecordEvent();

    // Display the progress of the goal
    public abstract void DisplayProgress();

    // Method to check if the goal is completed
    public virtual bool IsCompleted()
    {
        return _isCompleted;
    }
}
