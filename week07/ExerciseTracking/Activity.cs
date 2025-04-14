public abstract class  Activity
{
    protected string _name;

    protected double _time;

    protected DateTime _today = DateTime.Today;

    public Activity(double length)
    {
        _time = length;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();


    public virtual string GetSummary()
    {
        return $"{_today.ToString("D")} {_name} ({_time} min)- Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} min per mile";
    }


}