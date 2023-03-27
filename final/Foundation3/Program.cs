using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture l1 = new Lecture("John Snow", 500, "An evening with John Snow", "NULL", "April 1, 2023", "6:00 PM", "123 street");
        l1.GetStandardDetails();
    }
}