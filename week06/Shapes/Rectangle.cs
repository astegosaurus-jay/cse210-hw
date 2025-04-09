using System.Formats.Asn1;

public class Rectangle : Shapes
{
    private float _width;
    private float _length;


    public Rectangle(string color, float length, float width) : base(color)
    {
        _color = color;
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        float area = _width * _length;
        return area;
    }
}