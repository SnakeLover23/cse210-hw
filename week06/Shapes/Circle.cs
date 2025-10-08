using System;
public class Circle : Shape
{
    double _radius = 0;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double area = Math.PI * (_radius * _radius);
        return area;
    }
    public override string GetShape()
    {
        return "Circle";
    }
}