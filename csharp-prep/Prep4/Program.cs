using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numberList = new List<int>();

        Console.WriteLine("Hello Prep4 World!");
        
        Console.WriteLine("Enter a list of numbers, then type 0 when you are done");
        bool zero=false;
        while(!zero)
        {
            Console.Write("Enter a number: ");
            number=Convert.ToInt32(Console.ReadLine());
            numberList.Add(number);

            if (number==0)
            {
                zero=true;
            }
        }
        // for (int i = 0; i<numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }
        // This just prints out all the intigers in the list

        int sumOfAllNumbers=numberList.Sum();
        Console.WriteLine($"The sum of all numbers is: {sumOfAllNumbers}");


        float averageOfAllNumbers = ((float)sumOfAllNumbers/(numberList.Count-1));
        // int averageOfAllNumbers=sumOfAllNumbers/(numberList.Count-1);
        Console.WriteLine($"The average of all numbers is: {averageOfAllNumbers}");

        int largestNumber=numberList.Max();
        Console.WriteLine($"The largest number in the list was {largestNumber}");



    }
}