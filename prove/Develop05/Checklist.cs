public class Checklist : Goal
{
  private string _description;

  public Checklist(string description, string welcome) : base(welcome)
  {
    _description = description;
  }
}