using System;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!", "Well Done!");
        Activity activity = new Activity("Welcome to the Mindfulness Program" ,"Well Done!");
        Breathing breath = new Breathing("Welcome to the breathing activity!", "Well Done!");
        Listing list = new Listing("Welcome to the Listing Activity!", "Well Done!");
        Reflection reflect = new Reflection("Welcome to the reflection activity!", "Well Done!");
        Activity.menu(breath, list, reflect);
        // Activity.animation();
    }
}