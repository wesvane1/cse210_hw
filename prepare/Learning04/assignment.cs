public class Assignment
{
  // private useful only for the current class, cannot be used anywhere else.
  // protected can be used in any class that is derived from the parent class.
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