public class ReflectingActivity : Activity
{
    private List<string> _prompts = ["Think of a time you did something really difficult", "Think of a time you felt succesful", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", " prompt 5"];

    private List<string> _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "question 6"];


    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";

        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        ReflectingActivity a = new ReflectingActivity();
        Console.Clear();
        a.DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int i = int.Parse(Console.ReadLine());
        Console.Clear();
        
       
        Console.Write($"Get ready...");
        a.ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt: \n");
        a.DisplayPrompt();

        Console.Write("When you have something in mind, press enter to continue.");
        string enter = Console.ReadLine();


        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("you may begin in: ");
        a.ShowCountdown(5);
        Console.Clear();


        DateTime _startTime = DateTime.Now;
        DateTime endtime = _startTime.AddSeconds(i);

        while (DateTime.Now < endtime)
        {
            a.DisplayQuestion();
            a.ShowSpinner(5);
            Console.WriteLine("");
        }
        
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index];

        return prompt;
        
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        string question = _questions[index];

        return question;
        
    }

    public void DisplayPrompt()
    {
        ReflectingActivity i = new ReflectingActivity();
        Console.WriteLine($"---{i.GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        ReflectingActivity i = new ReflectingActivity();
        Console.WriteLine(i.GetRandomQuestion());
    }
}