// Track the following: Cycling: speed

// contain virtual methods for getting the distance, speed, pace

// GetSummary method to produce a string with all the summary information.
/*
Remember that the summary method can make use of the other methods to produce 
its result. This method should be available for all classes, so it should be 
defined in the base class (you can override it in the derived classes if needed, 
but it may not need to be...).
*/

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * (base._duration / 60.0); // Distance in miles
    }

    public override double GetPace() 
    {
        return 60.0 / _speed; // Pace in minutes per mile (Pace = 60 / speed)
    }

    public override string GetSummary()
    {
        double distanceInKm = GetDistance() * 1.60934; // Convert miles to kilometers
        double speedInKph = GetSpeed() * 1.60934; // Convert mph to kph
        double paceInMinutesPerKm = 60.0 / speedInKph; // Calculate pace in minutes per kilometer (Speed = 60 / pace)

        return $"{base.GetSummary()} - Speed: {_speed} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} min per mile" +
               $"\n{base.GetSummary()}: Distance: {distanceInKm:F1} km, Speed: {speedInKph:F1} kph, Pace: {paceInMinutesPerKm:F2} min per km";
    }
}