public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        char[] spinnerChars = { '|', '/', '-', '\\' };

        for (int i = 0; i < seconds; i++)
        {
            foreach (char spinnerChar in spinnerChars)
            {
                Console.Write(spinnerChar);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
