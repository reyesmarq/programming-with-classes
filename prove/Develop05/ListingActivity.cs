using System.Globalization;

public class ListingActivity : Activity
{
    private int _count;

    private readonly List<string> _prompts = [];

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        GetRandomPrompt();
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

        Console.WriteLine("List as many responses you can do to the following prompt: ");
        Console.WriteLine();

        GetRandomPrompt();
        Console.WriteLine();

        Console.Write("You may begin answer the prompt in: ");
        ShowCountDown(7);
        Console.WriteLine();

        List<string> answerList = GetListFromUser();
        _count = answerList.Count;
        Console.WriteLine($"You listed {_count} items!");

        Console.WriteLine();
        Console.WriteLine("Excellent!!");
        ShowSpinner(4);
        Console.WriteLine();

        DisplayEndingMessage();
        ShowSpinner(4);
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        Random random = new();
        int indexOfPrompt = random.Next(_prompts.Count);

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Console.WriteLine($"*--- {_prompts[indexOfPrompt]} ---*");
    }

    public List<string> GetListFromUser()
    {
        List<string> userAnswerList = [];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            userAnswerList.Add(input);
        }

        return userAnswerList;
    }
}
