using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Wes", "OOP");
        Console.WriteLine(assignment1.getSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Luke", "WWII", "14.3", "2,3,4,5,6");
        Console.WriteLine(mathAssignment1.getSummary());
        Console.WriteLine(mathAssignment1.getHomeworkList());

        WrittingAssignment writtingAssignment1 = new WrittingAssignment("Jake", "Social Studies", "How Minecraft changed the World");
        Console.WriteLine(writtingAssignment1.getSummary());
        Console.WriteLine(writtingAssignment1.GetWrittingInformation());
    }
}