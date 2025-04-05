using System.Diagnostics;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";

        _description = "This Activity will help you relax by walking you through breathing in and out slowly. \n Clear your mind and focus on breathing.";

        

    }


    public void Run()
    {
        BreathingActivity a = new BreathingActivity();
        Console.Clear();
        a.DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int i = int.Parse(Console.ReadLine());
        Console.Clear();
        

        Console.Write($"Get ready...");
        a.ShowSpinner(5);
        DateTime _startTime = DateTime.Now;
        DateTime endtime = _startTime.AddSeconds(i);

        while (DateTime.Now < endtime)
        {
            Console.WriteLine("\n");
            Console.Write("Breathe in...");
            a.ShowCountdown(4);
            Console.WriteLine("\n");
            Console.Write("Breathe out...");
            a.ShowCountdown(4);
        }
    }
}