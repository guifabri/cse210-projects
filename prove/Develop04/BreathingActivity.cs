public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description) { }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime futureTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
    }
}
