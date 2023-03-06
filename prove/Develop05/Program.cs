using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Goal g1 = new Goal("Welcome!");
        Simple s1 = new Simple("This activity will help you make a simple goal","Welcome to the Simple Goal Setter!");
        Checklist c1 = new Checklist("This will help you make a checklist goal!", "Welcome to the Checklist Goal Setter");
        Eternal e1 = new Eternal("This activity will help you make an eternal goal!", "Welcome to the Eternal Goal Setter!");
        g1.menu();
    }
}