// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.

public class OutdoorGathering:Event
{
    private string _weather;
    // Constructor
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather) : base(title, description, date, time, address){
        _weather = weather;
    }

    // return full details
    public override string GetFullDetails(){
        return $"{base.GetStandardDetails()}Event tyoe: Outdoor Gathering\nWeather: {_weather}";
    }
}