class WritingAssignment(string studentName, string topic, string title)
    : Assignment(studentName, topic)
{
    public string _title = title;

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}
