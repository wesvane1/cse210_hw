public class Simple : Goal
{
  private string _description;

  public Simple(string description, string welcome) : base(welcome)
  {
    _description = description;
  }
}