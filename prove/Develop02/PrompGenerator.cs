public class PromptGenerator
{
    public List<string> _prompts =
    [
        "How was your day?",
        "What is your favorite hobby?",
        "What is your biggest fear?",
        "What is a memorable childhood experience?",
        "What is your favorite movie and why?",
    ];

    public string GetRandomPrompt()
    {
        Random questionsOfList = new();
        string prompt = _prompts[questionsOfList.Next(_prompts.Count)];
        return prompt;
    }
}
