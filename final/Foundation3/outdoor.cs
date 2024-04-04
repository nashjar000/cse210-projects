// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.

public class OutdoorGathering:Event
{
    private string _weather;
    // Constructor
    // information needed: title, description, date, time, address, weather : base title, description, date, time, address
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    // return full details
    public override string GetFullDetails()
    {
        DateTime timeAsDateTime = DateTime.Today.Add(Time); // // This converts time to display in 12-hour format
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()} \nTime: {timeAsDateTime.ToString("h:mm tt")}\nAddress: {Address}\nEvent type: Outdoor Gathering\nWeather: {_weather}";
    }
}