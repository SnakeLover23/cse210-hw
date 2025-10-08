public class MathAssignment : Assignment
{
    string _textBookSection = "";
    string _problems = "";
    public MathAssignment(string textBookSection, string problems, string studentName, string topic) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{GetSummary()}\nSection: {_textBookSection} - Problems: {_problems}";
    }
}