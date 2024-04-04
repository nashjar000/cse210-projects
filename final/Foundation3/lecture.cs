// Lectures, which have a speaker and have a limited capacity.
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // information needed: title, description, date, time, address, speaker, capacity : base title, description, date, time, address
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        DateTime timeAsDateTime = DateTime.Today.Add(Time); // This converts time to display in 12-hour format
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()} \nTime: {timeAsDateTime.ToString("h:mm tt")}\nAddress: {Address}\nSpeaker: {_speaker}\nCapacity: {_capacity}\nEvent type: Lecture";
    }
}