public class ChecklistGoal : Goal
{

    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {

        _shortName = name;

        _description = description;

        _points = points;

        _target = target;

        _bonus = bonus;

        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Great Job! you earned {_points} points! \n And you completed your goal and earned {_bonus} bonus points!!");
            
        }
        else
        {
            // _amountCompleted ++ ;
            Console.WriteLine($"Congratulations! You earned\n {_points}!");
            
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetails()
    {
        if (_amountCompleted == _target)
        {
            return $"[X] {_shortName}: {_description}: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[] {_shortName}: {_description}: {_amountCompleted}/{_target}";
        }
        
    }

    public override string GetStringRepresntation()
    {
        throw new NotImplementedException();
    }

    public override int ReturnPoints()
    {
         if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
        
    }
}