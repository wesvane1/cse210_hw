public class Eternal : Goal
{
  private string _description;

  public Eternal(string description, string welcome) : base(welcome)
  {
    _description = description;
  }
}