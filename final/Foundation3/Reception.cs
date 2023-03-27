public class Reception : Event
{
  private string _email;

  public Reception(string eventType, string email, string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress):base(eventType, eventTitle, eventDescription, eventDate, eventTime, eventAddress)
  {
    _email = email;
  }

  public string GetStandardDetails()
  {
    return $"\n{_eventTitle}, {_eventDescription}, \nWhen {_eventDate}, {_eventTime}, \nWhere {_eventAddress}";
  }
  public string GetFullDetails()
  {
    return $"{GetStandardDetails()}, RSVP Email: {_email}";
  }
  public string GetShortDescription()
  {
    return $"\n{_eventType}: {_eventTitle}, \nWhen {_eventDate}";
  }
}