// Receptions, which require people to RSVP, or register, beforehand.

public class Reception:Event
{
    private string _RSVPEmail;

    // Constructor
    public Reception(string title, string description, DateTime date, TimeSpan time, 
    Address address, string RSVPEmail) : base(title, description, date, time, address){
        _RSVPEmail = RSVPEmail;
    }

    // return full details
    public override string GetFullDetails(){
        return $"{base.GetStandardDetails()}Event tyoe: Reception\nContact Email: {_RSVPEmail}";
    }
}