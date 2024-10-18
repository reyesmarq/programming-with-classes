class MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : Assignment(studentName, topic)
{
    public string _textbookSection = textbookSection;
    public string _problems = problems;

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
