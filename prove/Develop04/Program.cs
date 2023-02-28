using System;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!", "Well Done!");
        Activity activity = new Activity("Welcome to the Mindfulness Program" ,"Well Done!");
        Breathing breath = new Breathing("This activity will help you relax by walking you through some breathing exercises.","Welcome to the breathing activity!", "Well Done! You just completed a 30 second breathing activity!");
        Listing list = new Listing("This activity will allow you to write down all things that are going well in your life.","Welcome to the Listing Activity!", "Well Done! You just completed a 60 second breathing activity!");
        Reflection reflect = new Reflection("This activity will help you reflect on all things good in your life","Welcome to the reflection activity!", "Well Done! You completed a 30 second reflection activity!");
        activity.menu(breath, list, reflect);
    }
}