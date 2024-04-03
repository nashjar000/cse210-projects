// Track the following: Swimming: number of laps

// contain virtual methods for getting the distance, speed, pace

// GetSummary method to produce a string with all the summary information.
/*
Remember that the summary method can make use of the other methods to produce 
its result. This method should be available for all classes, so it should be 
defined in the base class (you can override it in the derived classes if needed, 
but it may not need to be...).
*/

// Distance (miles) = swimming laps * 50 / 1000 * 0.62

using System;

public class Swimming : Activity
{
    private int _laps;
    private double _lapDistance = 50; // distance in meters

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    // Get and set method for lap distance 
    public double LapDistance
    {
        get { return _lapDistance; }
        set { _lapDistance = value; }
    }

    // Distance (km) = swimming laps * 50 / 1000
    public override double GetDistance()
    {
        double distanceInKm = _laps * _lapDistance / 1000;
        return distanceInKm;
    }

    // Distance (miles) = swimming laps * 50 / 1000 * 0.62
    public override double GetSpeed()
    {
        double distanceInMiles = GetDistance() * 0.62;
        return (distanceInMiles / (base._duration / 60.0));
    }

    // Pace (min per mile or min per km)= minutes / distance
    public override double GetPace()
    {
        double distanceInMiles = GetDistance() * 0.62;
        return (base._duration / distanceInMiles);
    }

    public override string GetSummary()
    {
        double distanceInKm = GetDistance();
        double distanceInMiles = distanceInKm * 0.62;
        double speedInMph = GetSpeed();
        double speedInKph = speedInMph * 1.60934;
        double paceInMinutesPerMile = GetPace();
        double paceInMinutesPerKm = paceInMinutesPerMile / 0.62;

        return $"{base.GetSummary()} - Distance: {distanceInMiles:F2} miles, Speed: {speedInMph:F2} mph, Pace: {paceInMinutesPerMile:F2} min per mile" +
               $"\n{base.GetSummary()}: Distance: {distanceInKm:F2} km, Speed: {speedInKph:F2} kph, Pace: {paceInMinutesPerKm:F2} min per km";
    }
}
