using System.Threading.Channels;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    public void start()
    {
        int u2 = 0;

        while (u2 != 6)
        {
            DisplayPoints();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create new goal \n  2. List goals \n  3. Save goal \n  4. Load goals \n  5. Record event \n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            u2 = int.Parse(Console.ReadLine());

            if (u2 == 1)
            {
                CreateGoal();
            }

            else if (u2 == 2)
            {
                DisplayGoalDetails();
            }

            else if (u2 == 5)
            {
                RecordEvent();
            }

        }


    }


    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void DisplayGoalDetails()
    {
        int index = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}: {goal.GetDetails()}");
            index ++;
        }
    }

    public void CreateGoal()
    {
        string name = "";
        string description = "";
        int points = 0;
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
        Console.Write("Which goal would you like to create? ");
        int u1 = int.Parse(Console.ReadLine());

        if (u1 == 1)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("How many points do you wnat this goal to be? ");
            points = int.Parse(Console.ReadLine());
            SimpleGoal s1 = new SimpleGoal(name, description, points);
            _goals.Add(s1);
        }

        else if (u1 == 2)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("How many points do you wnat this goal to be? ");
            points = int.Parse(Console.ReadLine());
            EternalGoal e1 = new EternalGoal(name, description, points);
            _goals.Add(e1);
        }

        else if (u1 == 3)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("How many points do you wnat this goal to be? ");
            points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int times = int.Parse(Console.ReadLine());
            Console.Write("How many points will the bonus be? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal c1 = new ChecklistGoal(name, description, points, times, bonus);
            _goals.Add(c1);

        }

    }


    public void RecordEvent()
    {
        int index = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}: {goal.GetDetails()}");
            index ++;
        }
        Console.Write("Which goal would you like to record: ");
        int i1 = int.Parse(Console.ReadLine());
        Goal goal1 = _goals[i1];
        goal1.RecordEvent();
        _score += goal1.ReturnPoints();
    }
}