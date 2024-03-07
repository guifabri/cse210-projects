using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "Y";
        while (user == "Y")
        {
            Console.WriteLine("Welcome to the magic number game");
            Random number = new Random();
            int magicNumber = number.Next(1, 30);
            Console.Write("Please enter your lucky number: ");
            int luckyNumber = -1;
            int times = 0;
            while (luckyNumber != magicNumber)
            {
                luckyNumber = int.Parse(Console.ReadLine());
                times++;
                if (luckyNumber > magicNumber)
                {
                    Console.WriteLine("Try with a lower number");
                }
                else if (luckyNumber < magicNumber)
                {
                    Console.WriteLine("Try with a higher number");
                }
                else
                {
                    Console.WriteLine(
                        $"Congratulations you guessed you did it in ({times}) time(s)"
                    );
                }
            }
            Console.Write("Do you want to play again? Y/N ");
            user = Console.ReadLine().ToUpper();
        }
    }
}
