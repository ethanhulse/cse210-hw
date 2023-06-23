using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new Rectangle object
        Rectangle rect = new Rectangle("Red", 10, 20);
        //Create a new Circle object
        Circle circle = new Circle("Blue", 10);
        //Create a new Square object
        Square square = new Square("Green", 10);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(rect);
        shapes.Add(circle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Area of the {0}: {1}, Color: {2}", shape.GetType().Name, shape.getArea(), shape.getColor());
        }    
    }
}