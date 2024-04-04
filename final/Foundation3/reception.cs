// Receptions, which require people to RSVP, or register, beforehand.

public class Reception:Event
{
    private string _RSVPEmail;

    // Constructor
    // information needed: title, description, date, time, address, RSVPEmail : base title, description, date, time, address
    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string RSVPEmail) : base(title, description, date, time, address)
    {
        _RSVPEmail = RSVPEmail;
    }

    // return full details
    public override string GetFullDetails()
    {
        DateTime timeAsDateTime = DateTime.Today.Add(Time); // This converts time to display in 12-hour format
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()} \nTime: {timeAsDateTime.ToString("h:mm tt")}\nAddress: {Address}\nEvent type: Reception\nContact Email: {_RSVPEmail}";
    }
}