public abstract class Goal
{
  protected string _goal;
  protected string _basePoints;

  public void menu()
  {
    while (true)
    {
      Console.WriteLine("Menu Options");
      Console.WriteLine("1. Create New Goal");
      Console.WriteLine("2. ");
      Console.WriteLine("3. ");
      Console.WriteLine("4. ");
      Console.WriteLine("5. ");
      Console.WriteLine("6. ");
      Console.WriteLine("Please select an option");
      int selection = int.Parse(Console.ReadLine());
      if (selection == 1)
      {
        Console.WriteLine();
      }
      else if (selection == 6)
      {
        break;
      }
    }
  }
}