using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // This will start by displaying "AAA" and waiting for the user to press the enter key
        Console.WriteLine("I am happy");
        Console.WriteLine("Press the enter key to clear the text. NOT the power button");
        Console.ReadLine();

        // This will clear the console
        Console.Clear();

        // This will show "BBB" in the console where "AAA" used to be
        Console.WriteLine("The text was cleared");
    }
}