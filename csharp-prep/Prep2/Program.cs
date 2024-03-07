using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        string sign = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade % 10 >= 7 && letter != "F" && letter != "A")
        {
            sign = "+";
        }
        else if (grade % 10 < 3 && letter != "F")
        {
            sign = "-";
        }
        Console.WriteLine($"Your grade is ({letter}{sign}) .");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you approved.");
        }
        else
        {
            Console.WriteLine("Unfortunately you reproved, keep trying and don't quit.");
        }
    }
}
