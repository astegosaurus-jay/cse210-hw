public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

    public ListingActivity() : base()
    {
        _name = "Listing activity";

        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }

    public void Run()
    {
        ListingActivity a = new ListingActivity();
        Console.Clear();
        a.DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int i = int.Parse(Console.ReadLine());
        Console.Clear();
        
       
        Console.Write($"Get ready...");
        a.ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("List as many responses you can to the following prompt: ");
        a.GetRandomPrompt();
        Console.Write("You may begin in: ");
        a.ShowCountdown(5);
        Console.WriteLine();

        DateTime _startTime = DateTime.Now;
        DateTime endtime = _startTime.AddSeconds(i);
        List <string> userInput = new List<string>();
        while (DateTime.Now < endtime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            userInput.Add(input);
        }
        _count = userInput.Count;
        Console.WriteLine($"You listed {_count} items!");



    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine($"---{prompt}---");
    }

    public List<string> GetListFromUser()
    {
        List <string> userInput = new List<string>();
        string input = Console.ReadLine();
        userInput.Add(input);
        return userInput;
    }
}