using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Red", 3.2);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("Yellow", 2.4, 3.6);
        shapes.Add(rectangle);
        Circle circle = new Circle("Blue", 4);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetShape()}");
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine($"");
        }

        
    }
}