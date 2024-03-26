using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction num = new Fraction();
        Fraction num1 = new Fraction(6);
        Fraction num2 = new Fraction(6,7);
        Console.WriteLine(num.GetFractionString());
        Console.WriteLine(num.GetDecimalValue());
        Console.WriteLine(num1.GetFractionString());
        Console.WriteLine(num1.GetDecimalValue());
        Console.WriteLine(num2.GetFractionString());
        Console.WriteLine(num2.GetDecimalValue());
    }


}