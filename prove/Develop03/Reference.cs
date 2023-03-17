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
  }
  public Reference(string book, int chapter, int startVerse)
  {
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = -1;
  }

  public string getRef1()
  {
    return ($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
  }
}