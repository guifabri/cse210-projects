public class Conference : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
