using System;

class Program
{
    static void Main(string[] args)
    {
        // Read the journal entries from the file using StreamReader or other file-handling methods
        // Sample code for displaying a menu
        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select on of the following choices");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        // Prompt the user for input and handle their choice
        // Sample code for generating a random prompt and capturing user response
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What will I do today to make my day different?",
            // Add more prompts here
        };

        string randomPrompt = prompts[new Random().Next(prompts.Count)]; // Select a random prompt
        Console.WriteLine(randomPrompt);
        string userResponse = Console.ReadLine(); // Capture user response
    }
}
