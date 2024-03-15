// Sample code for creating the Entry class
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Add constructor and methods as needed
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}
