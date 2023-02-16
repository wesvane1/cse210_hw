public class Assignment
{
  protected string _studName;
  protected string _topic;
  public Assignment(string name, string topic)
  {
    _studName = name;
    _topic = topic;
  }
  public string getSummary()
  {
    return $"{_studName} - {_topic}";
  }
}