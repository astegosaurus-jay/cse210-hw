public class Running : Activity 
{
    private double _distance;


    public Running(double length, double distance) : base(length)
    {
        _time = length;

        _name = "Running";

        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculatePace()
    {
        return _time / _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / _time * 60;
    }


    // public override string GetSummary()
    // {
    //     return $"{_today.ToString("D")} {_name} ({_time} min)- Distance {_distance} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} min per mile";
    // }
}