public class Activity
{
    protected string _name;

    protected string _description;

    //protected int _duration;

    //protected DateTime _startTime = DateTime.Now;

    protected List<string> _animation = ["|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-"];    



    //public Activity(string name, string description, int duration)
    //{
        //_name = name;
        //_description = description;
        //_duration = duration;
    //}


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You did Great");
    }

    public void ShowSpinner(int seconds)
    {
        int i = 0;
       
        for (int b = seconds; b > 0; b-- )
        {
            string s = _animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >+ _animation.Count)
            {
                i = 0;
            }
        }


    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    
}