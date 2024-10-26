public abstract class Activity
{
    private string Date { get; }
    private int Minutes { get; }

    protected Activity(string date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    protected int ActivityMinutes => Minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Minutes} min) - "
            + $"Distance: {GetDistance():0.0} miles, "
            + $"Speed: {GetSpeed():0.0} mph, "
            + $"Pace: {GetPace():0.0} min per mile";
    }
}
