abstract class Goal
{
    protected string _name;
    protected int _points;
    protected string _description;

    public Goal(string name)
    {
        _name = name;
        _points = 0;
        _description = "";
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

    
}
