public class PromptGenerator
{
    public List<string> _prompts = ["How was your day", "What did you eat for breakfast", "Who did you interact with", "What did you do for school", "what are your plans for the weekend", "What is your goal today"];
    
    


    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index];

        return prompt;
    }
}