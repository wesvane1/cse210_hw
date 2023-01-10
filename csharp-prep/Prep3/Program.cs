using System;

class Program
{
    static void Main(string[] args)
    {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
            bool isGuessCorrect =false;
            while(!isGuessCorrect)
            {
                Console.Write("What is your guess?: ");
                string rawGuess = Console.ReadLine();
                int guess = int.Parse(rawGuess);

                if (magicNum > guess)
                {
                    Console.WriteLine("try Higher");
                }
                else if (magicNum < guess)
                {
                    Console.WriteLine("try lower");
                }
                else
                {
                    Console.WriteLine("Correct! Nice Job!");
                    isGuessCorrect=true;
                }
            }


    }
}