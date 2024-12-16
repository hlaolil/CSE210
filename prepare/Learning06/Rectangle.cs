using System;
using System.Collections.Generic;

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }

    public override double ComputeArea()
    {
        return Width * Height;
    }
}

