// Lectures, which have a speaker and have a limited capacity.
public class Lecture:Event
{
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
    }

    // return full details
    public override string GetFullDetails(){
        return $"{base.GetStandardDetails()}Event type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}