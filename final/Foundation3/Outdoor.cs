public class Outdoor : Event
{
  private string _weatherReport;

  public Outdoor(string weatherReport, string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress)
  {
    _weatherReport = weatherReport;
  }

  public string GetStandardDetails()
  {
    return $"{_eventTitle}, {_eventDescription}, \nWhere {_eventDate}, {_eventTime}, \nWhere{_eventAddress}";
  }
  public string GetFullDetails()
  {
    return "This needs to get standard details AND Weather Report";
  }
  public string GetShortDescription()
  {
    return "This needs to get the event type, title, and date";
  }
}