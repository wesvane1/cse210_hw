public class WrittingAssignment : Assignment
{
  private string _titleOfPaper;

  public WrittingAssignment(string name, string topic, string title) : base(name, topic)
  {
    _titleOfPaper = title;
  }

  public string GetWrittingInformation()
  {
    return $"Paper Title {_titleOfPaper}";
  }
}