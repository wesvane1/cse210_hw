public class Lecture : Event
{
  private string _speakerName;
  private int _lectureCapacity;

  public Lecture(string speakerName, int lectureCapacity, string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress)
  {
    _speakerName = speakerName;
    _lectureCapacity = lectureCapacity;
  }

  public string GetStandardDetails()
  {
    return "This needs to get a event title, event description, date, time, and address";
  }
  public string GetFullDetails()
  {
    return "This needs to get standard details AND Speaker name + capacity";
  }
  public string GetShortDescription()
  {
    return "This needs to get the event type, title, and date";
  }
}