// Remove the abstract
class Simple : Goal
{
  private int _goalAmount = 1;
  private int _timesCompleted;

  public bool _isComplete  = false;


  public Simple(string name, string description, int pointValue) : base(name, description, pointValue)
  {
    _description = description;
  }

  public override string GetGoalInfo()
  {
    return $"[ ] {_name} {_description} {_pointValue}";
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

  public override bool isComplete()
  {
    if (_timesCompleted > _goalAmount)
    {
      return _isComplete = true;
    }
    else
    {
      return _isComplete = false;
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