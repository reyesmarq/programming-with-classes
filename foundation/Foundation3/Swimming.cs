public class Swimming : Activity
{
    private int Laps { get; }
    private const double LapLength = 50 / 1609.34; // 50 meters converted to miles

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * LapLength;
    }

    public override double GetSpeed()
    {
        return GetDistance() / ActivityMinutes * 60;
    }

    public override double GetPace()
    {
        return ActivityMinutes / GetDistance();
    }
}
