using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 4),
            new Rectangle("Blue", 3, 5),
            new Circle("Green", 2),
            new Square("Yellow", 6),
            new Rectangle("Purple", 7, 2)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The {shape.Color} shape is a {shape} of Area = {shape.ComputeArea():F2}");
        }
    }
}
