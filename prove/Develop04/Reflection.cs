public class Reflection : Activity
{
  private string _description;
  private List<string> reflectionList = new List<string>()
  {
  "What makes you feel powerful?",
  "What makes you feel calm?",
  "What makes you feel in control?",
  "How do you encourage yourself when you're trying something new?",
  "What's a choice you can make this week based on your needs?",
  "How do you shift your mindset if it isn't working for you?",
  "How do you recharge?",
  "How can you celebrate yourself today?",
  "What does your situational best look like today?",
  "What helps you slow down and feel more present?",
  "What can you do today that you didn’t think you could do a year ago?",
  "What's a goal you want to accomplish and why?",
  "How do you put yourself first without feeling guilty?",
  "How do you practice self-acceptance?",
  "How do you stay focused and steer clear of distractions?",
  "How do you trust yourself to make big decisions?",
  "How do you set boundaries and avoid absorbing someone else's emotions and stress?",
  "How do you savor the time you get alone?",
  "How do you notice when you're nearing burnout?",
  "How do you share your feelings with the people who care about you?",
  "How do you swap envy for joy when other people accomplish things?",
  "How do you advocate for yourself?",
  "How do you forgive yourself when you make a mistake?",
  "How do you ask for help or support when you need it?",
  "How do you practice self-love and self-kindness?",
  "How do you calm your nerves in a difficult situation?",
  "How do you make the time you spend with people more intentional?",
  "How do you embrace your authentic self, even if it looks different from what others expect?",
  "How do you set and protect your boundaries?",
  "What new opportunities have come out of challenges you’ve faced?",
  "How can you step outside your comfort zone to grow?",
  "How do you remind yourself that you're enough?",
  };
  private List<string> reflectionPrompts = new List<string>()
  {
    "How did that make you feel?",
    "How did that experience change you for better or worse?",
    "Why do you feel that you needed the experience?"
  };
  public Reflection(string description, string welcome, string congrats) : base(welcome, congrats)
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

  private string setReflectEnd(string congrats)
  {
    _congrats = congrats;
    return congrats;
  }
  private string getReflectEnd()
  {
    return $"{_congrats}";
  }

  public bool CountDown (int seconds)
  {
    Console.WriteLine($"{getDescription()}");
    Console.WriteLine("Press any key to begin");
    Console.ReadKey();
    Random randInt = new Random();
    int randomChoice = randInt.Next(0, reflectionList.Count);
    Console.WriteLine(reflectionList[randomChoice]);
    Thread.Sleep(5000);
    bool stop = false;
    DateTime date = DateTime.Now;
    DateTime date2 = date.AddSeconds(seconds);
    
    do{
      seconds --;
      Thread.Sleep(1000);
      date = DateTime.Now;
      if (seconds ==1)
      {
        Console.WriteLine(reflectionPrompts[0]);
        Activity.animation();
      }
      if (seconds == 2)
      {
        Console.WriteLine(reflectionPrompts[1]);
        Activity.animation();
      }
      if (seconds == 3)
      {
        Console.WriteLine(reflectionPrompts[2]);
        Activity.animation();
      }
    }
    while (date < date2);
      stop = true;
      Console.WriteLine(getReflectEnd());
      return stop;
  }
}