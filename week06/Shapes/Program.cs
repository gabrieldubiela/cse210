using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("Yellow", 5));
        shapes.Add(new Rectangle("Blue", 5, 10));
        shapes.Add(new Square("Red", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}