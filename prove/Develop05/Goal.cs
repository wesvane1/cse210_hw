abstract class Goal
{
  protected string _name;
  protected string _description;
  protected int _pointValue;

  public Goal(string name, string description, int pointValue)
  {
    _name=name;
    _description=description;
    _pointValue = pointValue;
  }

  public abstract string GetGoalName();
  public abstract string GetGoalDescription();
  public abstract int GetGoalPoints();
  public abstract string isComplete();
  public abstract int recordEvent();
  public abstract string GetGoalInfo();
}