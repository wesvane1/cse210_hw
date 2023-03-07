public class Simple : Goal
{
  public int newTotal;
  private string _description;
  public string _goalName;

  public Simple(string description, string welcome) : base(welcome)
  {
    _description = description;
  }

  public string testStorage()
  {
    Console.Write("What would you like your goal to be?: ");
    string goalName = Console.ReadLine();
    Console.WriteLine("How many points?: ");
    int num = int.Parse(Console.ReadLine());
    return $"{goalName} worth {num}";
  }
}