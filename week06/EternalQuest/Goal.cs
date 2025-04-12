using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

public abstract class Goal
{
    protected string _shortName;

    protected string _description;

    protected int _points;


    public Goal (string name, string description, int points)
    {
        _shortName = name; 

        _description = description;

        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetails()
    {
        bool a = IsComplete();
        if (a == true)
        {
            return $"[X] {_shortName}: {_description} ";
        }
        else
        {
            return $"[] {_shortName}: {_description}";
        }
        
    }

    public abstract string GetStringRepresntation();

    public abstract int ReturnPoints();
}