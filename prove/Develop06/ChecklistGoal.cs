using System.Globalization;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private readonly int _target;
    private readonly int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int GetPoints()
    {
        int points = int.Parse(_points, CultureInfo.InvariantCulture);

        if (IsComplete())
        {
            points += _bonus;
        }
        return points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!");
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string baseString = base.GetDetailsString();
        return $"{baseString} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}
