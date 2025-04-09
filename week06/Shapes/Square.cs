public class Square : Shapes
{
    private float _side;

    public Square(string color, float side) : base(color)
    {
        _color = color;

        _side = side;
    }

    public override double GetArea()
    {
        float area = _side * _side;
        return area;
    }
}