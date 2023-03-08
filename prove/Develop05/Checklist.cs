class Checklist : Goal
{
  private int _goalAmount;
  private int _timesCompleted;

  public Checklist(string name, string description) : base(name, description)
  {
    _description = description;
  }

  public int getGoalAmount()
  {
    Console.WriteLine("How many times would you like to do this?: ");
    int goalAmount = int.Parse(Console.ReadLine());
    return goalAmount;
  }

  public string getChecklistGoal()
  {
    return "placeholder";
  }

  public override bool isComplete()
  {
    if (_timesCompleted > _goalAmount)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public override int recordEvent()
  {
    throw new NotImplementedException();
  }
}