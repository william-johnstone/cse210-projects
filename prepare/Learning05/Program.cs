using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("Orange", 5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Yellow", 4, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 6);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }

    public static void DisplayShapeInfo(Shape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine($"Color is: {shape.GetColor()}");
        Console.WriteLine($"Area is {area}");
    }
}