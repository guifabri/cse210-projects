using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Erick scala", "Biology");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);
        MathAssignment mathAssignment = new MathAssignment(
            "7.3",
            "8-19",
            "erick scala",
            "Fractions"
        );
        string information = mathAssignment.GetHomeworkList();
        Console.WriteLine(information);
        WritingAssignment writingAssignment = new WritingAssignment(
            "The Causes of World War II by Mary Waters",
            "Mary Waters",
            "European History"
        );
        string newbook = writingAssignment.GetWritingInformation();
        Console.WriteLine(newbook);
    }
}
