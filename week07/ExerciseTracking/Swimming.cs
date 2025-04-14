using System.Security.Cryptography.X509Certificates;

public class Swimming : Activity
{
    private double _laps;


    public Swimming(double laps, double time) : base(time)
    {
        _laps = laps;

        _time = time;

        _name = "Swimming";
        
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 *0.62;
    }

    public override double CalculatePace()
    {
        return _time / CalculateDistance();
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / _time * 60;
    }

}