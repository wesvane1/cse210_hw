using System;

abstract class Exercise
{
  protected string _date;
  protected string _activityName;
  protected int _duration;
  protected double _distance;

  public Exercise(string date, string activityName, int duration, double distance)
  {
    _date = date;
    _activityName = activityName;
    _duration = duration;
    _distance = distance;
  }

  // ! Speed and Pace will be determined by the duration and distance
  //  * Speed = (distance/duration)*60
  //  * Pace = duration/distance

  public abstract double GetPace();
  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract string GetSummary();
}