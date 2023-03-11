// Remove the abstract
class SimpleGoal : Goal
{
  // private int _goalAmount = 1;
  private int _timesCompleted;

  private bool _isComplete  = false;


  public SimpleGoal(string name, string description, int pointValue, bool isComplete) : base(name, description, pointValue)
  {
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

  public override string GetGoalInfo()
  {
    return $"[ ] {_name}, ({_description})";
  }

  // public override void completeGoal()
  // {
  //   _isComplete = true;
  //   isComplete();
  // }

  public override string isComplete()
  {
    _isComplete = true;
    if (_isComplete == true) {
      return $"[X] {_name} ({_description}) {_pointValue}";
    }
    else {
      return $"[ ] {_name} ({_description}) {_pointValue}";
    }
  }


// ! The line below needs to be a bool, same for all, but it needs to return the [X] in the line. It also needs to return a certain number of points
// ! Professor has this listed out in teams.
  // public override string isComplete()
  // {
  //   if (_timesCompleted == _goalAmount)
  //   {
  //     return $"[X] {_name} {_description} {_pointValue}";
  //   }
  //   else
  //   {
  //     return $"Goal already completed";
  //   }
  // }
  public override int recordEvent()
  {
    Console.WriteLine("Which goal were you able to complete?");
    int goalNum = int.Parse(Console.ReadLine());
    Console.WriteLine(goalNum);
    // goalList{goalNum}._timesCompleted ++;
    return _timesCompleted ++;
  }

  public override string organizeGoal()
  {
    return $"Simple:{_name},{_description},{_pointValue},{_isComplete}";
  }
}