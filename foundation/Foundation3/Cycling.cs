public class Cycling : Activity
{
    private double Speed { get; }

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * ActivityMinutes / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}
