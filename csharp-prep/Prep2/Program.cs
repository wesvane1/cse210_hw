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
            string letter= "A";
            Console.WriteLine($"You got an {letter} in this class! You passed!");
        }
        else if (grade >= 80)
        {
            string letter= "B";
            Console.WriteLine($"You got an {letter} in this class! You passed!");
        }
        else if (grade >= 70)
        {
            string letter= "C";
            Console.WriteLine($"You got an {letter} in this class! You passed!");
        }
        else if (grade >= 60)
        {
            string letter= "D";
            Console.WriteLine($"You got an {letter} in this class. You may want to consider retaking the course");
        }
        else
        {
            string letter= "F";
            Console.WriteLine($"You got an {letter} in this class. You may want to consider retaking the course");
        }
    }
}