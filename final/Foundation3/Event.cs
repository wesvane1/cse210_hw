using System;

public class Event
{
  protected string _eventTitle;
  protected string _eventDescription;
  protected string _eventDate;
  protected string _eventAddress;
  protected string _eventTime;
  protected string _eventType;

  public Event(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress)
  {
    _eventType = eventType;
    _eventTitle = eventTitle;
    _eventDescription = eventDescription;
    _eventDate = eventDate;
    _eventTime = eventTime;
    _eventAddress = eventAddress;
  }
}