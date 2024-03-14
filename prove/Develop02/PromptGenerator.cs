// Sample code for creating the PromptGenerator class
public class PromptGenerator
{
    // Prompt the user for input and handle their choice
    // Sample code for generating a random prompt and capturing user response
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What will I do today to make my day different?",
        // Add more prompts here
    };

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)]; // Select a random prompt
    }
}
