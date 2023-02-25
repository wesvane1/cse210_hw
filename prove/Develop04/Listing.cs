public class Listing : Activity
{
  private string _description;
  private List<string> listingPrompts = new List<string>()
  {
    "What do you like most about yourself?",
    "What are you most grateful for?",
    "When have you been able to see the people around you lift you up?",
    "Who do you think is the most supportive person in your life right now?",
    "When have you been able to feel the Holy Ghost this week?"
  };
  public Listing(string description, string welcome, string congrats): base(welcome, congrats)
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

  public string seListEnd(string congrats)
  {
    _congrats  = congrats;
    return congrats;
  }
  public string getListEnd()
  {
    return $"{_congrats}";
  }
  public bool CountDown (int seconds)
  {
    Console.WriteLine(getDescription());
    Console.WriteLine("Please reflect on the following statement");
    Console.WriteLine("Press any key to begin");
    Console.ReadKey();
    Random randInt = new Random();
    int randomChoice = randInt.Next(0, listingPrompts.Count);
    Console.WriteLine(listingPrompts[randomChoice]);
    bool stop = false;
    DateTime date = DateTime.Now;
    DateTime date2 = date.AddSeconds(seconds);
    do{
      // The below line will write out the number of seconds that has elapsed
      seconds --;
      Thread.Sleep(1000);
      date = DateTime.Now;
      if (seconds != 60)
      {
        Console.Write("");
        Console.ReadLine();
      }
    }
    while (date < date2);
      stop = true;
      Console.WriteLine(getListEnd());
      return stop;
  }
}
