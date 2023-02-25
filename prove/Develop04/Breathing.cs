public class Breathing : Activity
{
  public Breathing(string welcome, string congrats) : base(welcome, congrats)
  {

  }

  public string setBreathingActivityStart(string welcome)
  {
    _welcome  = welcome;
    return welcome;
  }
  public string getBreathingActivityStart()
  {
    return $"{_welcome}";
  }
  public string seBreathingActivityEnd(string congrats)
  {
    _congrats  = congrats;
    return congrats;
  }
  public string getBreathingActivityEnd()
  {
    return $"{_congrats}";
  }

  public bool CountDown (int seconds)
  {
    Console.WriteLine("Press any key to begin");
    Console.ReadKey();
    Console.WriteLine("Breath In...");
    bool stop = false;
    DateTime date = DateTime.Now;
    DateTime date2 = date.AddSeconds(seconds);
    do{
      // The below line will write out the number of seconds that has elapsed
      seconds --;
      Thread.Sleep(1000);
      date = DateTime.Now;
      if (seconds == 30 || seconds == 22 || seconds == 14 || seconds == 6)
      {
        Console.Clear();
        Console.WriteLine("Breath In...");
      }
      else if (seconds == 26 || seconds == 18 || seconds ==10 || seconds == 2)
      {
        Console.Clear();        
        Console.WriteLine("Breath Out...");
      }
    }
    while (date < date2);
      stop = true;
      Console.WriteLine(_congrats);
      return stop;
  }
}