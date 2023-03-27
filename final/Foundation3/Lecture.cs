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
    return $"{_eventTitle}, {_eventDescription}, \nWhere {_eventDate}, {_eventTime}, \nWhere{_eventAddress}";
  }
  public string GetFullDetails()
  {
    return $"{GetStandardDetails()}, \nWho{_speakerName}, \nCapacity: {_lectureCapacity}";
  }
  public string GetShortDescription()
  {
    return "This needs to get the event type, title, and date";
  }
}