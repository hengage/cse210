using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fractions f1 = new Fractions();
        Fractions f2 = new Fractions(5);
        Fractions f3 = new Fractions(3, 4);


        Console.WriteLine($"Fraction 1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");
        f1.SetTop(10);
        f1.SetBottom(2);
        Console.WriteLine($"Fraction 1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

        Console.WriteLine($"Fraction 2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");
    }
}