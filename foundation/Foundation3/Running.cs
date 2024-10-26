public class Running : Activity
{
    private double Distance { get; }

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / ActivityMinutes * 60;
    }

    public override double GetPace()
    {
        return ActivityMinutes / Distance;
    }
}
