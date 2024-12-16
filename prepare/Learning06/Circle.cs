using System;
using System.Collections.Generic;

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    public override double ComputeArea()
    {
        return Math.PI * Radius * Radius;
    }

}


