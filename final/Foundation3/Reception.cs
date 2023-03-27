public class Reception : Event
{
  private string _email;

  public Reception(string eventType, string email, string eventTitle, string eventDescription, string eventDate, string eventTime):base(eventType, eventTitle, eventDescription, eventDate, eventTime)
  {
    _email = email;
  }

  public string GetStandardDetails()
  {
    return $"\n{_eventTitle}, {_eventDescription} \nWhen {_eventDate}, {_eventTime}";
  }
  public string GetFullDetails()
  {
    return $"{GetStandardDetails()} \nRSVP @ {_email}";
  }
  public string GetShortDescription()
  {
    return $"\n{_eventType}: {_eventTitle} \nWhen {_eventDate}";
  }
}