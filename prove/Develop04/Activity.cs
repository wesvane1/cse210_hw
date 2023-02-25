using System;
using System.Timers;

public class Activity
{
  //  private  static int count = 0;
  //  private static System.Timers.Timer aTimer;
  
  // protected int _time;
  protected string _welcome;
  protected string _congrats;
  protected string _activity;

  // public static void Timer()
  //   {
  //     SetTimer();
  //     Console.ReadLine();
  //     aTimer.Stop();
  //     aTimer.Dispose();
  //   }
  public Activity(string welcome, string congrats)
  {
    // _time = time;
    _welcome = welcome;
    _congrats = congrats;
  }
  public void menu(Breathing breath, Listing list, Reflection reflect)
  {
    Console.WriteLine("Welcome to the Mindfulness Program\nWhat would you like to do?");
    Console.WriteLine("1: Breathing Activity\n2: Listing Activity\n3: Reflection Activity");
    Console.WriteLine("Please select one of the following options: ");
    int selection = int.Parse(Console.ReadLine());
    if (selection == 1)
    {
      string activityName = "Breathing";
      Console.WriteLine($"You have chosen the {activityName} activity");
      breath.CountDown(30);
      // I am trying to get a string of the activity name to be able to call at any point.
    }
    else if (selection == 2)
    {
      string activityName = "Listing";
      Console.WriteLine($"You have chosen the {activityName} activity");
      list.CountDown(60);
    }
    else if (selection == 3)
    {
      string activityName = "Reflection";
      Console.WriteLine($"You have chosen the {activityName} activity!");
      reflect.CountDown(3);
    }
  }

  // The following method shows the animation.

  protected static void animation()
  {
    List<string> Animation = new List<string>();
    Animation.Add("|");
    Animation.Add("/");
    Animation.Add("-");
    Animation.Add("\\");
    Animation.Add("|");
    Animation.Add("/");
    Animation.Add("-");
    Animation.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(10);
    int i=0;
    while (DateTime.Now < endTime)
    {
      string s = Animation[i];
      Console.Write(s);
      Thread.Sleep(1000);
      Console.Write("\b \b");

      i++;

      if (i >= Animation.Count)
      {
        i = 0;
      }
    }
  }
}