using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square1 = new("Red", 4);
        Rectangle rectangle1 = new("Blue", 4, 5);
        Circle circle1 = new("Green", 3);
        
        List<Shape> shapes = new List<Shape>
        {
            square1,
            rectangle1,
            circle1
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}\n");
        }
    }
}