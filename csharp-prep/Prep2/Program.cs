using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What was your grade in the class?: ");
        string userInput=Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade >=90)
        {
            string letter ="A";
            Console.WriteLine($"You got an {letter} in the class! Congratulations!");
        }
        if (grade >=80)
        {
            string letter ="B";
            Console.WriteLine($"You got an {letter} in the class!");
        }
        if (grade >=70)
        {
            string letter ="C";
            Console.WriteLine($"You got an {letter} in the class!");
        }
        if (grade >=60)
        {
            string letter ="D";
            Console.WriteLine($"You got an {letter} in the class! You may want to consider retaking the course.");
        }
        if (grade <60)
        {
            string letter ="F";
            Console.WriteLine($"You got an {letter} in the class! You may want to consider retaking the course.");
        }

    }
}