using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    // Properties
    public string Title { get { return _title; } }
    public string Description { get { return _description; } }
    public DateTime Date { get { return _date; } }
    public TimeSpan Time { get { return _time; } }
    public Address Address { get { return _address; } }

    // Constructor
    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Standard details
    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    // Full details
// Full details
public virtual string GetFullDetails()
{
    // Format the time in the desired format
    string formattedTime = _date.Add(_time).ToString("h:mm tt");

    // Return the full details including the formatted time
    return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {formattedTime}\nAddress: {_address.GetFullAddress()}";
}

    // Short description
    public virtual string GetShortDescription()
    {
        return $"Event Type: General\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
