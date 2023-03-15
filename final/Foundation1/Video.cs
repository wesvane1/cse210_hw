using System;

class Video
{
  public string _videoTitle="";
  public string _videoAuthor="";
  public int _videoLength=0;
  public List<Comment> _comment1 = new List<Comment>();
  public List<Comment> _comment2 = new List<Comment>();
  public List<Comment> _comment3 = new List<Comment>();

  public void Display()
  {
    Console.WriteLine($"\n{_videoTitle} by {_videoAuthor}");
    foreach (Comment comment in _comment1)
    {
      comment.Display();
    }

    foreach (Comment comment in _comment2)
    {
      comment.Display();      
    }

    foreach (Comment comment in _comment3)
    {
      comment.Display();      
    }

    // For each comment in videos console.wl(videotitle: commentAuthor, commentText)
  }
}