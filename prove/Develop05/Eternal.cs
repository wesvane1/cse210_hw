class Eternal : Goal
{
  public Eternal(string name, string description) : base(name, description)
  {
    _description = description;
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