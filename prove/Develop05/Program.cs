using System;

class Program
{
    static List<string> GoalList = new List<string>();
    static void Main(string[] args)
    {
        //
        // Goal g1 = new Goal("Welcome!");

        SimpleGoal s1 = new SimpleGoal("This activity will help you make a simple goal","Welcome to the SimpleGoal Goal Setter!", 0);
        Checklist c1 = new Checklist("This will help you make a checklist goal!", "Welcome to the Checklist Goal Setter", 0, 3, 0);
        Eternal e1 = new Eternal("This activity will help you make an eternal goal!", "Welcome to the Eternal Goal Setter!", 0);
        while (true)
        {
        Console.WriteLine("\nMenu Options");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Please select an option: ");
        int selection = int.Parse(Console.ReadLine());
        if (selection == 1)
        {
            Console.WriteLine("\n1. Simple");
            Console.WriteLine("2. Eternal");
            Console.WriteLine("3. Checklist");
            Console.Write("What goal will it be?: ");
            int newSelection = int.Parse(Console.ReadLine());
            if (newSelection == 1)
            {
                SimpleGoal newS1 = new SimpleGoal(s1.GetGoalName(), s1.GetGoalDescription(), s1.GetGoalPoints());
                Console.WriteLine(newS1.GetGoalInfo());
                GoalList.Add(newS1.GetGoalInfo());
            }
            else if (newSelection == 2)
            {
                Eternal newE1 = new Eternal(e1.GetGoalName(), e1.GetGoalDescription(), e1.GetGoalPoints());
                Console.WriteLine(newE1.GetGoalInfo());
                GoalList.Add(newE1.GetGoalInfo());
            }
            else if (newSelection == 3)
            {
                Checklist newC1 = new Checklist(c1.GetGoalName(), c1.GetGoalDescription(), c1.GetGoalPoints(), c1.GetGoalAmount(), 0);
                Console.WriteLine(newC1.GetGoalInfo());
                GoalList.Add(newC1.GetGoalInfo());
            }
        }
        else if (selection == 2)
        {
            foreach (string goal in GoalList)
            {
                Console.WriteLine(goal);
            }
            Console.WriteLine("List Goals!!");
        }
        else if (selection == 3)
        {
            Console.WriteLine("Save Goals!!");
            Console.Write("What file would you like to save your goals to?: ");
            string fileName = Console.ReadLine();
            // using (StreamWriter outputFile = new StreamWriter(fileName))
            // {
            //     foreach(string goal in GoalList)
            //     {
            //         outputFile.WriteLine(GoalList);
            //     }
            // }
                // This code deletes everything in the file and rewrites it

                // You can add text to the file with the WriteLine method
                // outputFile.WriteLine("This will be the Second line in the file.");
                
                // You can use the $ and include variables just like with Console.WriteLine
                // string color = "Red";
                // outputFile.WriteLine($"My favorite color is {color}");
        }
        else if (selection == 4)
        {
            Console.WriteLine("Load Goals");
            Console.WriteLine("What file would you like to load goals from?: ");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in GoalList)
            {
                string[] parts = line.Split(",");
            }
        }
        else if (selection == 5)
        {
            Console.WriteLine("Record Event!!");
        }

        else if (selection == 6)
        {
            break;
        }
        }
    }
}