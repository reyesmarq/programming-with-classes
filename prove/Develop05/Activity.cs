public class Activity
{
    private readonly string _name;
    private readonly string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How many seconds would you like for your session? ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(
            $"Congratulations! You have completed another {_duration} seconds of the {_name} Activity."
        );
    }

    // Static since it doesn't depend on the instance of the class
    public static void ShowSpinner(int seconds)
    {
        List<string> animations = ["|", "/", "—", "\\"];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string symbol = animations[i];
            Console.Write(symbol);
            Thread.Sleep(400);
            Console.Write("\b \b");

            i += 1;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }

    // Static since it doesn't depend on the instance of the class
    public static void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
