class Checklist : Goal
{
  private int _goalAmount;
  private int _timesCompleted = 0;
  private int _bonusPoint;
  public bool _isComplete = false;

  public Checklist(string name, string description, int pointValue, int bonusPoint, int goalAmount, int timesCompleted, bool isComplete) : base(name, description, pointValue)
  {
    _goalAmount = goalAmount;
    _timesCompleted = timesCompleted;
    _bonusPoint = bonusPoint;
    this._isComplete = isComplete;
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
    Console.Write("How many points would you like this goal to be worth?: ");
    int pointValue = int.Parse(Console.ReadLine());
    return pointValue;
  }
  public int GetBonusPoints()
  {
    Console.Write("How many bonus points would you like for fully completing the goal?: ");
    int bonusPoint = int.Parse(Console.ReadLine());
    return bonusPoint;
  }
  public int GetGoalAmount()
  {
    Console.Write("How many times would you like to do this goal?: ");
    int goalAmount = int.Parse(Console.ReadLine());
    return goalAmount;
  }

  public override string GetGoalInfo()
  {
    return $"[ ] {_name} ({_description}) - {_timesCompleted}/{_goalAmount}";
  }

  public override void completeGoal()
  {
    if (_timesCompleted == _goalAmount)
    {
      _isComplete = true;
    }
    else
    {
      _isComplete = false;
    }
  }

  public override string isComplete()
  {
    if (_timesCompleted == _goalAmount)
    {
      return $"[x] {_name} ({_description}) - {_timesCompleted}/{_goalAmount}";
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
  public override string organizeGoal()
  {
    return $"Checklist:{_name},{_description},{_pointValue},{_bonusPoint},{_timesCompleted},{_goalAmount},{_isComplete}";
  }
}