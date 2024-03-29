using System;

class Cycling : Exercise
{
  public Cycling(string date, string activityName, int duration, double distance) : base(date, activityName, duration, distance)
  {}
  public override double GetPace()
  {
    double pace = Math.Round((_duration/GetDistance()),2);
    return pace;
  }

  public override double GetDistance()
  {
    return _distance;
  }

  public override double GetSpeed()
  {
    double speed = Math.Round((GetDistance()/_duration)*60,2);
    return speed;
  }

  public override string GetSummary()
  {
    return $"{_date} ({_duration} min)- Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min mile";
  }
}