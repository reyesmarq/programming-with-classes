class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =
        [
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 30, 9.7),
            new Swimming("03 Nov 2022", 30, 20),
        ];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

