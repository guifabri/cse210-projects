public class Reception : Event
{
    public string ConfirmationEmail { get; set; }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nConfirmation Email: {ConfirmationEmail}";
    }
}
