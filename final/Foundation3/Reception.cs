public class Reception : Event
{
  private string _email;

  public Reception(string email, string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress)
  {
    _email = email;
  }

  public string GetStandardDetails()
  {
    return "This needs to get a event title, event description, date, time, and address";
  }
  public string GetFullDetails()
  {
    return "This needs to get standard details AND RSVP Email";
  }
  public string GetShortDescription()
  {
    return "This needs to get the event type, title, and date";
  }
}