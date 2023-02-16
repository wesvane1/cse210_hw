public class MathAssignment : Assignment
{
  private string _sectionNumber;
  private string _problems;

  public MathAssignment(string name, string topic, string section, string problem) : base (name, topic)
  {
    _sectionNumber = section;
    _problems = problem;
  }

  public string getHomeworkList()
  {
    return $"Section {_sectionNumber}, problems {_problems}";
  }
}