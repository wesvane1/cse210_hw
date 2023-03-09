// Remove the abstract
class SimpleGoal : Goal
{
  private int _goalAmount = 1;
  private int _timesCompleted;

  public bool _isComplete  = false;


  public SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
  {

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

  public override string GetGoalInfo()
  {
    return $"[ ] {_name} ({_description}) {_pointValue}";
  }

  // public override bool isComplete()
  // {

  // }

  public string testStorage()
  {
    Console.Write("What would you like your goal to be?: ");
    string goalName = Console.ReadLine();
    Console.WriteLine("How many points?: ");
    int num = int.Parse(Console.ReadLine());
    return $"{goalName} worth {num}";
  }

  public override string isComplete()
  {
    if (_timesCompleted == _goalAmount)
    {
      return $"[X] {_name} {_description} {_pointValue}";
    }
    else
    {
      return $"Goal already completed";
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