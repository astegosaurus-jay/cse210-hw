public class Biking : Activity
{
    private double _speed;


    public Biking(double speed, double time) : base (time)
    {
        _speed = speed;

        _time = time;

        _name = "Cycling";
    }


    public override double CalculateDistance()
    {
        return _time / 60 * _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }
}