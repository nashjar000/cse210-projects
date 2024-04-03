// Track the following: Running: distance

// contain virtual methods for getting the distance, speed, pace

// GetSummary method to produce a string with all the summary information.
/*
Remember that the summary method can make use of the other methods to produce 
its result. This method should be available for all classes, so it should be 
defined in the base class (you can override it in the derived classes if needed, 
but it may not need to be...).
*/

// Speed (mph or kph) = (distance / minutes) * 60
// Pace (min per mile or min per km)= minutes / distance
// Speed = 60 / pace
// Pace = 60 / speed

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    // Speed (mph or kph) = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (60.0 / (base._duration / _distance)); // Speed in miles per hour
    }

    // Pace (min per mile or min per km)= minutes / distance
    public override double GetPace()
    {
        return (60.0 / GetSpeed()); // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        double distanceInKm = _distance * 1.60934; // Convert miles to kilometers
        double speedInMph = GetSpeed();
        double speedInKph = speedInMph * 1.60934; // Convert mph to kph
        double paceInMinutesPerMile = GetPace();
        double paceInMinutesPerKm = 60.0 / speedInKph; // Calculate pace in minutes per kilometer

        return $"{base.GetSummary()} - Distance: {_distance} miles, Speed: {speedInMph:F1} mph, Pace: {paceInMinutesPerMile:F1} min per mile" +
               $"\n{base.GetSummary()}: Distance: {distanceInKm:F1} km, Speed: {speedInKph:F1} kph, Pace: {paceInMinutesPerKm:F2} min per km";
    }
}
