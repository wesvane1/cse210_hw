using System;

class Swimming : Exercise
{
  public Swimming(string date, string activityName, int duration, double distance) : base(date, activityName, duration, distance)
  {}
  public override double GetPace()
  {
    double pace = (_duration/_distance);
    return pace;
  }

  public override double GetDistance()
  {
    double distance = Math.Round((_distance * 50) / (1000 * .62),2);
    return distance;
  }

  public override double GetSpeed()
  {
    double speed = Math.Round((GetDistance()/_duration)*60, 2);
    return speed;
  }

  public override string GetSummary()
  {
    return $"{_date} ({_duration} min)- Distance {GetDistance()} miles ({_distance} laps), Speed: {GetSpeed()} mph, Pace: {GetPace()} min per lap";
  }
}