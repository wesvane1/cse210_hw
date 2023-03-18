public class Outdoor : Event
{
  private string _weatherReport;

  public Outdoor(string weatherReport, string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress)
  {
    _weatherReport = weatherReport;
  }

  public string GetStandardDetails()
  {
    return "This needs to get a event title, event description, date, time, and address";
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