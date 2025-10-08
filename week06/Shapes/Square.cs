public class Square : Shape
{
    double _side = 0;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
    public override string GetShape()
    {
        return "Square";
    }
}