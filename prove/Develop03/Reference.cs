public class Reference
{
  private string _book;
  private int _chapter;
  private int _startVerse;
  private int _endVerse;

  public Reference(string book, int chapter, int startVerse, int endVerse)
  {
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
    // The line below writes the reference to the consol.
    // Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{endVerse}");
  }
  public Reference(string book, int chapter, int startVerse)
  {
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = -1;
    // The line below writes the reference to the consol.
    // Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{endVerse}");
  }

  public string getRef1()
  {
    return ($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
  }
}