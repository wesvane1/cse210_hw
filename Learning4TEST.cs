using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Book book1 = new Book("Magic Tree House", "Wes Vane");
        Console.WriteLine(book1.getBookInfo());

        PictureBook book2 = new PictureBook("Your mom", "Savanna Boston", "Aly Bish");
        Console.WriteLine(book2.getPictureBookInfo());
        
        Book book3 = new Book("Squidward", "Happy Day UnderWater");
        Console.WriteLine(book3.getBookInfo());
    }
}
public class Book
{
    // Private means that something is private ONLY to the class that it is in.
    // protecteed menad that something is accessable to all classes that are derived from the parent class.
    protected string _title;
    protected string _author;
    public Book()
    {
        _title = "Unkown Title";
        _author = "Unknown Author";
    }
    public Book(string title, string author)
    {
        _title = title;
        _author = author;
    }
    public string getBookTitle()
    {
        return _title;
    }
    public void setTitle(string title)
    {
        _title = title;
    }
    public string getBookAuthor()
    {
        return _author;
    }
    public void setAuthor(string author)
    {
        _author = author;
    }
    public string getBookInfo()
    {
        return ($"{_title} by {_author}");
    }
}

public class PictureBook : Book
{
    private string _illustrate  = "";

    public PictureBook() : base()
    {

    }
    public PictureBook(string title, string author, string illustrate) : base (title, author)
    {
        _illustrate = illustrate;
    }

    public string getIllustrator()
    {
        return _illustrate;
    }
    public void setIllustrator(string illustrate)
    {
        _illustrate = illustrate;
    }
    public string getPictureBookInfo()
    {
        return $"{_title} by {_author} with {_illustrate}";
    }
}