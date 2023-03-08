class Checklist : Goal
{
  private int _goalAmount;
  private int _timesCompleted;

  public Checklist(string name, string description, int pointValue, int goalAmount, int timesCompleted) : base(name, description, pointValue)
  {
    _name = name;
    _description = description;
    _pointValue = pointValue;
    _goalAmount = goalAmount;
    _timesCompleted = timesCompleted;
  }

  public override string GetGoalInfo()
  {
    return $"[ ] {_name} {_description} - {_timesCompleted}/{_goalAmount}";
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
    Console.WriteLine("Which goal were you able to complete?");
    Console.WriteLine("Goal Placeholder");
    int goalNum = int.Parse(Console.ReadLine());
    Console.WriteLine(goalNum);
    // goalList{goalNum}._timesCompleted ++;
    return _timesCompleted ++;
  }
}