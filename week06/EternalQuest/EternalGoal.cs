public class EternalGoal : Goal
{


    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        _shortName = name;

        _description = description;

        _points = points;
    }


    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {_points}!");
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresntation()
    {
        throw new NotImplementedException();
    }

    public override int ReturnPoints()
    {
        return _points;
    }
}