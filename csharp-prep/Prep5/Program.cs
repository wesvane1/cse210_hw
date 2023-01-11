using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string userName=PromptUserName();
        int userNumber=PromptUserNumber();
        int square=SquareNumber(userNumber);

        DisplayMessage(userName, square);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program with functions!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name?: ");
            string name=Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?: ");
            int favNum=int.Parse(Console.ReadLine());
            return favNum;
        }
        static int SquareNumber(int userNumber)
        {
            int square=userNumber*userNumber;
            return square;
        }

        static void DisplayMessage(string userName, int square)
        {
            Console.WriteLine($"Your name is {userName}, and your favorite number squared is {square}");
        }



    }
}