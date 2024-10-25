using System.Globalization;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public string GetShortName()
    {
        return _shortName;
    }

    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }

    public virtual int GetPoints()
    {
        return int.Parse(_points, CultureInfo.InvariantCulture);
    }

    public abstract string GetStringRepresentation();

    public override bool Equals(object obj)
    {
        return obj is Goal goal && _shortName == goal._shortName;
    }
}
