using System;

public class Event
{
  protected string _eventTitle;
  protected string _eventDescription;
  protected string _eventDate;
  protected string _eventTime;
  protected string _eventType;

  public Event(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime)
  {
    _eventType = eventType;
    _eventTitle = eventTitle;
    _eventDescription = eventDescription;
    _eventDate = eventDate;
    _eventTime = eventTime;
  }
}