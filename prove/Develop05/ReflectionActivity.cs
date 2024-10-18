using System.Globalization;

public class ReflectionActivity : Activity
{
    private const int V = 0;
    private const int V1 = 0;
    private readonly List<string> _prompts =
    [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    ];

    private readonly List<string> _questions =
    [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    ];

    private int _promptIndex = V;
    private int _questionIndex = V1;

    public ReflectionActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        Shuffle(_prompts);
        Shuffle(_questions);
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayReflectionPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine(
            "Now ponder on each of the following questions as they relate to this experience."
        );
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (_questionIndex >= _questions.Count)
            {
                Console.WriteLine("All questions have been asked. Ending early...");
                break; // Stop if no more questions
            }

            DisplayReflectionQuestions();
            ShowSpinner(5);
            Console.WriteLine();
        }

        Console.WriteLine("Well done!!");
        ShowSpinner(4);
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(4);
        Console.Clear();
    }

    private static void Shuffle<T>(List<T> list)
    {
        Random rng = new();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (list[n], list[k]) = (list[k], list[n]);
        }
    }

    public void DisplayReflectionPrompt()
    {
        if (_promptIndex >= _prompts.Count)
        {
            _promptIndex = 0;
            Shuffle(_prompts);
        }

        Console.WriteLine($"--- {_prompts[_promptIndex++]} ---");
    }

    public void DisplayReflectionQuestions()
    {
        if (_questionIndex >= _questions.Count)
        {
            _questionIndex = 0;
            Shuffle(_questions);
        }

        Console.Write($"> {_questions[_questionIndex++]} ");
    }
}
