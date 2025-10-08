public class Rectangle : Shape
{
    double _length = 0;
    double _width = 0;
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
    public override string GetShape()
    {
        return "Rectangle";
    }
}