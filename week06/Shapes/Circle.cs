public class Circle : Shapes
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _color = color;
        _radius = radius;
    }

    public override double GetArea()
    {
        
        return _radius * _radius * Math.PI;
    }
}