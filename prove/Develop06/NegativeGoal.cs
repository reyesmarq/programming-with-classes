public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, string points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"I'm sorry to hear that, you have lost {GetPoints() * -1} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }

    public override int GetPoints()
    {
        return base.GetPoints() * -1;
    }
}
