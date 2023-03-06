using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Goal g1 = new Goal("Welcome!");
        Simple s1 = new Simple("This activity will help you make a simple goal","Welcome");
        g1.menu();
    }
}