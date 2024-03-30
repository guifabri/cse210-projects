public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description)
        : base(name, description)
    {
        _prompts = new List<string>
        {
            "Remember a moment when you overcame a significant challenge.",
            "Think of a difficult situation you've recently faced.",
            "Imagine a moment when you tackled a challenging task.",
            "Reflect on an obstacle you've successfully overcome.",
            "Consider a moment when you exerted a lot of effort to achieve something.",
            "Recall a time when you faced a significant challenge and emerged victorious.",
            "Think of a moment when you felt overwhelmed but found a solution.",
            "Reflect on a tough situation where you demonstrated determination and perseverance.",
            "Remember a moment when you faced a complicated task and completed it successfully.",
            "Imagine a challenge you've overcome and how you felt upon achieving it."
        };
        _questions = new List<string>
        {
            "Do you remember a moment when you faced a significant challenge? What did you do to overcome it?",
            "Can you think of a difficult situation you've faced recently? How did you handle that situation?",
            "Imagine a moment when you tackled a challenging task. What strategies did you use to address it?",
            "Have you encountered any major obstacles that you've successfully overcome? How did you feel upon achieving it?",
            "Do you recall a time when you exerted a lot of effort to achieve something? What motivated you to keep going?",
            "Think of a moment when you faced a significant challenge and emerged victorious. How did you prepare to face it?",
            "Was there a time when you felt overwhelmed but found a solution? How did you resolve the situation?",
            "Can you remember a tough situation where you demonstrated your determination and perseverance? What did you learn from that experience?",
            "Do you recall a moment when you faced a complicated task and completed it successfully? How did you feel upon finishing it?",
            "Can you imagine a challenge you've overcome and how you felt upon achieving it? What drove you to keep going despite the difficulties?"
        };
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine(
            "Now ponder on each of the following questions as they related to this experience."
        );
        Console.Write($"You may begin in: ");
        ShowCountDown(4);
        Console.Clear();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
        }
    }

    public string publicGetRandomQuestion()
    {
        return "";
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}
