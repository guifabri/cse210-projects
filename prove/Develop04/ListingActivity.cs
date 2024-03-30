using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description)
        : base(name, description)
    {
        _prompts = new List<string>
        {
            "Describe a moment this month when you felt the presence of the Holy Ghost.",
            "Share an experience from this month where you felt a spiritual connection with the Holy Ghost.",
            "Reflect on a specific occasion in the past month when you felt touched by the Holy Ghost.",
            "Recall a time in the recent month when you sensed the influence of the Holy Ghost in your life.",
            "Think back to a moment in the current month when you experienced the comforting presence of the Holy Ghost."
        };
        _count = 0;
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("--List as many responses you can to the following prompt--\n");
        Console.WriteLine(GetRandomPrompt());
        Console.Write($"You may begin in: ");
        ShowCountDown(4);
        Console.WriteLine();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items\n");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        return [""];
    }
}
