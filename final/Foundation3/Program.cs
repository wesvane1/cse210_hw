using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture l1 = new Lecture("Lecture" ,"John Snow", 500, "An evening with John Snow", "Talking about Finances", "April 1, 2023", "6:00 PM", "123 street");
        Console.WriteLine("\n-----Lecture-----");
        Console.WriteLine("--Standard Details--");
        Console.WriteLine(l1.GetStandardDetails());
        Console.WriteLine("\n--Full Details--");
        Console.WriteLine(l1.GetFullDetails());
        Console.WriteLine("\n--Short Description--");
        Console.WriteLine(l1.GetShortDescription());

        Outdoor o1 = new Outdoor("Outdoor", "Sunny", "Neighborhood Picnic", "Get everyone together for this picnic!", "April 5, 2023", "2:00 PM", "456 B Street");
        Console.WriteLine("\n-----Outdoor-----");
        Console.WriteLine("\n--Standard Details--");
        Console.WriteLine(o1.GetStandardDetails());
        Console.WriteLine("\n--Full Details--");
        Console.WriteLine(o1.GetFullDetails());
        Console.WriteLine("\n--Short Description--");
        Console.WriteLine(o1.GetShortDescription());

        Reception r1 = new Reception("Reception", "email@google.com", "Smith's Reception", "Come celebrate the newly wed Smiths", "April 30, 2023", "8:00 PM", "789 C Street");
        Console.WriteLine("\n-----Reception-----");
        Console.WriteLine("\n--Standard Details--");
        Console.WriteLine(r1.GetStandardDetails());
        Console.WriteLine("\n--Full Details--");
        Console.WriteLine(r1.GetFullDetails());
        Console.WriteLine("\n--Short Description--");
        Console.WriteLine(r1.GetShortDescription());
    }
}