// https://byui-cse.github.io/cse210-course-2023/unit01/csharp-1.html

// Go to this website above to learn more about what C# is and how it acts.

using System;

class Program
{
    static void Main(string[] args)
    {
        // int x = 5;
        // Console.WriteLine((x)*5);
        // The line above will print the number 5
        // You can do Console.WriteLine((x)*5); and that will output 25 instead of 5

        // Console.WriteLine("There will be a new line");
        // Console.WriteLine("This is a test");
        // Console.Write("Is there a line after this?");
        // Console.Write("This is another test");
        // Console.Write does not create a new line after printing

        // Console.Write("What is your favorite color?: ");
        // string color = Console.ReadLine();
        // if (color == "blue")
        // {
        //     Console.WriteLine("My favorite color is blue too!");
        // }
        // else
        // {
        //     Console.WriteLine($"Your favorite color is {color}? Nice, mine is blue.");
        // }

        
        // This is the program

        Console.Write("What is your first name?: ");
        string fName = Console.ReadLine();
        Console.Write("What is your last name?: ");
        string lName = Console.ReadLine();

        Console.Write($"Your name is {lName}, {fName} {lName}?");
    }
}