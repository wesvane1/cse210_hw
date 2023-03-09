class Eternal : Goal
{
  public Eternal(string name, string description, int pointValue) : base(name, description, pointValue)
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
    return $"{_name} {_description} {_pointValue}";
  }

  public override string isComplete()
  {
    return $"Keep it up, you're doing great!";
  }
  public override int recordEvent()
  {
    throw new NotImplementedException();
  }
}