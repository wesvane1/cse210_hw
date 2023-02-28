using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>();

       Square s1 = new Square("Blue", 12);
       shapes.Add(s1);

       Rectangle r1 = new Rectangle("Red", 4, 2);
       shapes.Add(r1);

       Circle c1 = new Circle("Orange", 2);
       shapes.Add(c1);

       

       foreach (Shape shape in shapes)
       {
        string color = shape.GetColor();
        double area = shape.GetArea();
        Console.WriteLine($"The {color} shape has an area of {area}");
       }
    }
}