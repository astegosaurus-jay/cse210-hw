using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("purple", 8);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("blue", 5, 8);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("green", 6);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());


        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shapes shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console. WriteLine($"The color is {color}, and the area is {area}");
        }
    }
}