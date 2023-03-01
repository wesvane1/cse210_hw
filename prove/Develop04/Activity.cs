using System;
using System.Timers;

public class Activity
{

  protected string _welcome;
  protected string _congrats;
  protected string _activity;

  public Activity(string welcome, string congrats)
  {
    _welcome = welcome;
    _congrats = congrats;
  }
  public void menu(Breathing breath, Listing list, Reflection reflect)
  {
    while(true)
    {
      Thread.Sleep(1500);
      Console.WriteLine("\nWelcome to the Mindfulness Program\nWhat would you like to do?");
      Console.WriteLine("1: Breathing Activity\n2: Listing Activity\n3: Reflection Activity\n4: Quit");
      Console.WriteLine("Please select one of the following options: ");
      int selection = int.Parse(Console.ReadLine());
      if (selection == 1)
      {
        Console.WriteLine($"You have chosen the Breathing activity");
        breath.CountDown(30);
      }
      else if (selection == 2)
      {
        Console.WriteLine($"You have chosen the Listing activity");
        list.CountDown(60);
      }
      else if (selection == 3)
      {
        Console.WriteLine($"You have chosen the Reflection activity!");
        reflect.CountDown(3);
      }
      else if (selection == 4)
      {
        break;
      }
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