
public class PromptGenerator
{
    private List<string> _promptText;

    public PromptGenerator()
    {
        _promptText = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_promptText.Count);  // Get a random index
        return _promptText[index];  // Return the prompt at that index
    }

}

