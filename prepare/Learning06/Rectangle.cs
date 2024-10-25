public class Rectangle(string color, double length, double width) : Shape(color)
{
    private readonly double _length = length;
    private readonly double _width = width;

    public override double GetArea()
    {
        return _length * _width;
    }
}
