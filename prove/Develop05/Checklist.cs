class Checklist : Goal
{
  private int _goalAmount;
  private int _timesCompleted = 0;

  public Checklist(string name, string description, int pointValue, int goalAmount, int timesCompleted) : base(name, description, pointValue)
  {
    _goalAmount = goalAmount;
    _timesCompleted = timesCompleted;
  }
  public override string GetGoalName()
  {
    Console.Write("What would you like your goal to be?: ");
    string name = Console.ReadLine();
    return name;
  }
  public override string GetGoalDescription()
  {
    Console.Write("Please provide a short description of the goal: ");
    string description = Console.ReadLine();
    return description;
  }
  public override int GetGoalPoints()
  {
    Console.Write("How many points would you like this goal to be worth?");
    int pointValue = int.Parse(Console.ReadLine());
    return pointValue;
  }
  public string GetGoalAmount()
  {
    Console.WriteLine("How many times would you like to do this goal?: ");
    string goalAmount = Console.ReadLine();
    return goalAmount;
  }

  public override string GetGoalInfo()
  {
    return $"[ ] {_name} {_description} - {_timesCompleted}/{_goalAmount}";
  }

  public override string isComplete()
  {
    if (_timesCompleted == _goalAmount)
    {
      return $"[x] {_name} {_description} - {_timesCompleted}/{_goalAmount}";
    }
    else if(_timesCompleted > _goalAmount)
    {
      return $"Already Completed";
    }
    else
    {
      return GetGoalInfo();
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