public class Lecture : Event
{
  private string _speakerName;
  private int _lectureCapacity;

  public Lecture(string eventType, string speakerName, int lectureCapacity, string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress):base(eventType, eventTitle, eventDescription, eventDate, eventTime, eventAddress)
  {
    _speakerName = speakerName;
    _lectureCapacity = lectureCapacity;
  }

  public string GetStandardDetails()
  {
    return $"\n{_eventTitle}, {_eventDescription}, \nWhen {_eventDate}, {_eventTime}, \nWhere {_eventAddress}";
  }
  public string GetFullDetails()
  {
    return $"{GetStandardDetails()}, \nWho {_speakerName}, \nCapacity: {_lectureCapacity}";
  }
  public string GetShortDescription()
  {
    return $"\n{_eventType}: {_eventTitle}, \nWhen {_eventDate}";
  }
}