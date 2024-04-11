public class Reception : Event
{
    private string _confirmationEmail;

    public string ConfirmationEmail
    {
        get { return _confirmationEmail; }
        set { _confirmationEmail = value; }
    }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nConfirmation Email: {_confirmationEmail}";
    }
}
