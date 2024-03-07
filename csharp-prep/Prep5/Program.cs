using System;

class Program
{
    static string name;
    static int num;

    static void DisplayWelcome()
    {
        Console.Write("Welcome my dear friend.");
    }

    static void PromptUserName()
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
    }

    static void PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        num = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult()
    {
        Console.Write($"Hi! {name}, the square for your number is {SquareNumber(num)}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        DisplayResult();
    }
}
