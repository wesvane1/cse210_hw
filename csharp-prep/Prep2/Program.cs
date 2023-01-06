using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What was your grade for this course? (input in percent): ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade >= 90)
        {
            Console.WriteLine("You got an A in this class!");
        }
        if (grade >= 80)
        {
            Console.WriteLine("You got an B in this class!");
        }
        if (grade >= 70)
        {
            Console.WriteLine("You got an C in this class!");
        }
        if (grade >= 60)
        {
            Console.WriteLine("You got an D in this class. You may want to consider retaking the course");
        }
        if (grade < 60)
        {
            Console.WriteLine("You got an F in this class. You may want to consider retaking the course");
        }
    }
}