public class Listing : Activity
{
  private List<string> listingPrompts = new List<string>()
  {
    "What do you like most about yourself?",
    "What are you most grateful for?",
    "When have you been able to see the people around you lift you up?",
    "Who do you think is the most supportive person in your life right now?",
    "When have you been able to feel the Holy Ghost this week?"
  };
  public Listing(string welcome, string congrats): base(welcome, congrats)
  {

  }
  public string setListingActivityStart(string welcome)
  {
    _welcome  = welcome;
    return welcome;
  }
  public string getListingActivityStart()
  {
    return $"{_welcome}";
  }
  public string seListingActivityEnd(string congrats)
  {
    _congrats  = congrats;
    return congrats;
  }
  public string getListingActivityEnd()
  {
    return $"{_congrats}";
  }
  public bool CountDown (int seconds)
  {
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
      Console.WriteLine(_congrats);
      return stop;
  }
}
