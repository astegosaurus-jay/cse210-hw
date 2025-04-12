using System.Security.AccessControl;

public class SimpleGoal : Goal
{


    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _shortName = name;

        _description = description;

        _points = points;

        _isComplete = false;
    }


    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You earned {_points}!");
        
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
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