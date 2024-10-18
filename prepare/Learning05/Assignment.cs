public class Assignment(string studentName, string topic)
{
    private readonly string _studentName = studentName;
    private readonly string _topic = topic;

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}
