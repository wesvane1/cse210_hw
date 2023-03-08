class Eternal : Goal
{
  public Eternal(string name, string description, int pointValue) : base(name, description, pointValue)
  {
    _description = description;
  }

  public override string GetGoalInfo()
  {
    return $"{_name} {_description} {_pointValue}";
  }

  public override bool isComplete()
  {
    return false;
  }
  public override int recordEvent()
  {
    throw new NotImplementedException();
  }
}