public class Outdoor : Event
{
  private string _weatherReport;

  public Outdoor(string eventType, string weatherReport, string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress):base(eventType, eventTitle, eventDescription, eventDate, eventTime, eventAddress)
  {
    _weatherReport = weatherReport;
  }

  public string GetStandardDetails()
  {
    return $"\n{_eventTitle}, {_eventDescription}, \nWhen {_eventDate}, {_eventTime}, \nWhere {_eventAddress}";
  }
  public string GetFullDetails()
  {
    return $"{GetStandardDetails()}, \nWeather: {_weatherReport}";
  }
  public string GetShortDescription()
  {
    return $"\n{_eventType}: {_eventTitle}, \nWhen {_eventDate}";
  }
}