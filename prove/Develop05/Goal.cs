public class Goal
{
  protected string _welcome;
  protected string _goal;
  protected int _basePoints;
  protected int subtotal = 0;

  public Goal(string welcome)
  {
    _welcome = welcome;
  }

  public void menu(Simple s1)
  {
    List<string> testList = new List<string>();
    while (true)
    {
      Console.WriteLine($"You have {subtotal} points!");
      Console.WriteLine("\nMenu Options");
      Console.WriteLine("1. Create New Goal");
      Console.WriteLine("2. List Goals");
      Console.WriteLine("3. Save Goals");
      Console.WriteLine("4. Load Goals");
      Console.WriteLine("5. Record Event");
      Console.WriteLine("6. Quit");
      Console.WriteLine("Please select an option");
      int selection = int.Parse(Console.ReadLine());
      if (selection == 1)
      {
        Console.Clear();
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.WriteLine("What goal will it be?");
        int newSelection = int.Parse(Console.ReadLine());
        if (newSelection == 1)
        {
          Console.Clear();
          testList.Add(s1.testStorage());
          Console.WriteLine(testList);
        }
      }
      else if (selection == 2)
      {
        Console.Clear();
        Console.WriteLine("List Goals!!");
      }
      else if (selection == 3)
      {
        Console.Clear();
        Console.WriteLine("Save Goals!!");
      }
      else if (selection == 4)
      {
        Console.Clear();
        Console.WriteLine("Load Goals");
      }
      else if (selection == 5)
      {
        Console.Clear();
        Console.WriteLine("Record Event!!");
      }

      else if (selection == 6)
      {
        break;
      }
    }
  }
}