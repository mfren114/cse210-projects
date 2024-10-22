using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning06 World!");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 5);
        shapes.Add(square);
        

        Regtangle rectangle = new Regtangle("black", 5, 6);
        shapes.Add(rectangle);
        

        Circle circle = new Circle("purple", 5);
        shapes.Add(circle);
        
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}