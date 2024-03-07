using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> items = new List<float>();
        float number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number please: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                items.Add(number);
            }
        }
        Console.WriteLine(
            $"All elements add: {items.Sum()} with average {Math.Round(items.Average(), 2)} maximum number {items.Max()}"
        );
        Console.WriteLine($"Smallest positive number: {items.Where(num => num > 0).Min()} ");
        items.Sort();
        foreach (float num in items)
        {
            Console.WriteLine(num);
        }
    }
}
