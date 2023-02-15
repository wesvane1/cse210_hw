using System;

class Programmmmmm
{


  static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Random randomNum = new Random();
        int randomNumber = randomNum.Next(0,19);
        
        string[] words = {"For", "behold", "this", "is", "my", "work", "and", "my", "glory", "to", "bring", "to", "pass", "the", "immortality", "and", "eternal", "life", "of", "man"};
        string randomWord = words[randomNumber];
        Console.WriteLine(words[randomNumber]);
        Console.WriteLine(randomWord.Length);

        string dashed = "";
        for (int charNum = 0; charNum < randomWord.Length; charNum++) 
          {
            string dash = ("_");
            dashed += dash;
            words[randomNumber] = dashed;
          }
        Console.WriteLine(dashed);
        Console.WriteLine("{0}", string.Join(" ", words));

        // This is for the main program

        Console.WriteLine("What book will this scripture be in?");
        string bookRef = Console.ReadLine();

        Console.WriteLine("What chapter will the scripture be in?");
        string chapterRef = Console.ReadLine();

        Console.WriteLine("What verse(s) will you be memorizing?");
        string verseRef = Console.ReadLine();

        Console.WriteLine("What is the scripture?");
        string scrip = Console.ReadLine();
        Console.WriteLine($"{bookRef} {chapterRef}:{verseRef} {scrip}");

        // Add parameters for the reference constructor
         Referenceeeee reference = new Referenceeeee("Proverbs", "3", "5", "6");
        //  Reference reference2 = new Reference("John", "3", "16");
         Scriptureeeee scripture = new Scriptureeeee(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        //  Scripture scripture2 = new Scripture(reference2, "test");

    }
}

class Referenceeeee
{
  private string _book;
  private string _chapter;
  private string _startVerse;
  private string _endVerse;
  public Reference(string book, string chapter, string startVerse, string endVerse)
  {
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
    Console.WriteLine($"{_book} {_chapter}:{_startVerse}{endVerse}");
  }
    public Reference(string book, string chapter, string startVerse)
  {
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
  }
  public string Get1()
  {
    return ($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
  }
  public string Get2()
  {
    return ($"{_book} {_chapter}:{_startVerse}");
  }
}


class Scriptureeeee
{
  private string _scripture;
  // private string _scripture2;

  public Scripture(Reference reference, string scripture){
    _scripture = scripture;
    Console.WriteLine($"{reference.Get1()} {scripture}");
  }
  // public Scripture(Reference reference2, string scripture){
  //   _scripture2 = scripture;
  //   Console.WriteLine($"{reference2.Get2()} {scripture}");
  // }

}