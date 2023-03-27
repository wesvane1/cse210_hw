using System;

abstract class Exercise
{
  protected string _date;
  protected string _activityName;
  protected int _duration;
  protected int _distance;

  // ! Speed and Pace will be determined by the duration and distance
  //  * Speed = (distance/duration)*60
  //  * Pace = duration/distance

  public abstract int GetPace();
  public abstract int GetDistance();
  public abstract int GetSpeed();
  public abstract string GetSummary();
}