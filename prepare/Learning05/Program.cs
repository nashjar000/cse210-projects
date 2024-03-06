using System;

class Program
{
    static void Main(string[] args)
    {
        // list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Create a square, set its color and side length, and add it to the list of shapes
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        // Create a rectangle, set its color, length, and width, and add it to the list of shapes
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        // Create a circle, set its color and radius, and add it to the list of shapes
        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);
    
        // Go through the list of shapes
        foreach (Shape s in shapes)
        {
            // Get the color of the shape
            string color = s.GetColor();

            // Get the area of the shape
            double area = s.GetArea();

            // Print the color and area of the shape
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}