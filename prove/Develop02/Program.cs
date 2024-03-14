using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        Entry getEntry = new Entry();
        float number = -1;
        while (number != 5)
        {
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine("Please select on of the following choices");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                getEntry._date = theCurrentTime.ToShortDateString();
                getEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(getEntry._promptText);
                getEntry._entryText = Console.ReadLine();
            }
        }
    }
}
