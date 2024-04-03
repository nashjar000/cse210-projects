/*
03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
*/

public class Activity
{
    private DateTime _date;
    protected int _duration; 

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yy} {GetType().Name} ({_duration} min)";
    }
}