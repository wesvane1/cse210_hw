public class Breathing : Activity

// How do I call back to the menu that sits in the activity class?

{
  private string _description;

  public Breathing(string description, string welcome, string congrats) : base(welcome, congrats)
  {
    _description = description;
  }

  private string setDescription(string description)
  {
    _description = description;
    return description;
  }

  private string getDescription()
  {
    return $"{_description}";
  }
  public string seBreathEnd(string congrats)
  {
    _congrats  = congrats;
    return congrats;
  }
  public string getBreathEnd()
  {
    return $"{_congrats}";
  }

  public bool CountDown (int seconds)
  {
    int i = 0;
    Console.WriteLine($"{getDescription()}");
    Console.WriteLine("Press any key to begin");
    Console.ReadKey();
    Console.WriteLine("Breath In...");
    bool stop = false;
    DateTime date = DateTime.Now;
    DateTime date2 = date.AddSeconds(seconds);
    do{
      // The below line will write out the number of seconds that has elapsed
      seconds --;
      date = DateTime.Now;
      if (seconds == 30 || seconds == 22 || seconds == 14 || seconds == 6)
      {
        Console.Clear();
        Console.Write("Breath In...");
        for (i = 5; i > 0; i--)
        {
          Console.Write(i);
          Thread.Sleep(1000);
          Console.Write("\b \b");
        }
      }
      else if (seconds == 26 || seconds == 18 || seconds ==10 || seconds == 2)
      {
        Console.Clear();        
        Console.Write("Breath Out...");
        for (i = 5; i > 0; i--)
        {
          Console.Write(i);
          Thread.Sleep(1000);
          Console.Write("\b \b");
        }
      }
    }
    while (date < date2);
      stop = true;
      Console.WriteLine(getBreathEnd());
      return stop;
  }
}