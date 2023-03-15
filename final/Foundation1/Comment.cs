using System;

class Comment
{
  public string _commentName="";
  public string _commentText="";

  public void Display()
  {
    Console.WriteLine($"{_commentName}: {_commentText}");
  }
}