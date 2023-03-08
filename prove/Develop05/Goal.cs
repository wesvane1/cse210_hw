abstract class Goal
{
  protected string _name;
  protected string _description;
  protected string _goal;
  protected int _basePoints;
  protected int subtotal = 0;

  public Goal(string name, string description)
  {
    _name=name;
    _description=description;
  }
  public abstract bool isComplete();
  public abstract int recordEvent();
}