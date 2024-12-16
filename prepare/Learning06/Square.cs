using System;
using System.Collections.Generic;

class Square : Shape
{
    public double Side { get; set; }

    public Square(string color, double side) : base(color)
    {
        Side = side;
    }

    public override double ComputeArea()
    {
        return Side * Side;
    }

}

