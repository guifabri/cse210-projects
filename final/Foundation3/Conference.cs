public class Conference : Event
{
    private string _speaker;
    private int _capacity;

    public string Speaker
    {
        get { return _speaker; }
        set { _speaker = value; }
    }

    public int Capacity
    {
        get { return _capacity; }
        set { _capacity = value; }
    }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
