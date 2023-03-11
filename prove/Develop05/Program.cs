using System;

class Program
{
    static List<Goal> GoalList = new List<Goal>();

    // SimpleGoal simpleGoal;
    static void Main(string[] args)
    {
        //
        // Goal g1 = new Goal("Welcome!");

        // SimpleGoal s1;
        SimpleGoal s1 = new SimpleGoal("This activity will help you make an eternal goal!", "Welcome to the Eternal Goal Setter!", 0, false);
        Checklist c1 = new Checklist("This will help you make a checklist goal!", "Welcome to the Checklist Goal Setter",0, 30, 3, 0, false);
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
                // You can declare all string names here, instead of outsourcing to all classes
                SimpleGoal newS1 = new SimpleGoal(s1.GetGoalName(), s1.GetGoalDescription(), s1.GetGoalPoints(), false);
                Console.WriteLine(newS1.GetGoalInfo());
                GoalList.Add(newS1);
            }
            else if (newSelection == 2)
            {
                Eternal newE1 = new Eternal(e1.GetGoalName(), e1.GetGoalDescription(), e1.GetGoalPoints());
                Console.WriteLine(newE1.GetGoalInfo());
                GoalList.Add(newE1);
            }
            else if (newSelection == 3)
            {
                Checklist newC1 = new Checklist(c1.GetGoalName(), c1.GetGoalDescription(), c1.GetGoalPoints(), c1.GetBonusPoints(), c1.GetGoalAmount(), 0, true);
                Console.WriteLine(newC1.isComplete());
                GoalList.Add(newC1);
            }
        }
        else if (selection == 2)
        {
            foreach (Goal goal in GoalList)
            {
                Console.WriteLine(goal.GetGoalInfo());
            }
            Console.WriteLine("List Goals!!");
        }
        else if (selection == 3)
        {
            Console.WriteLine("Save Goals!!");
            Console.Write("What file would you like to save your goals to?: ");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(Goal goal in GoalList)
                {
                    outputFile.WriteLine(goal.organizeGoal());
                }
            }
        }
        else if (selection == 4)
        {
            Console.WriteLine("Load Goals");
            Console.Write("What file would you like to load goals from?: ");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(":");
                string[] goalInfo = parts[1].Split(",");

                if (parts[0] == "Simple") {
                    SimpleGoal simpleGoal = new SimpleGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), bool.Parse(goalInfo[3]));
                    GoalList.Add(simpleGoal);
                }
                else if (parts[0] == "Eternal")
                {
                    Eternal eternalGoal = new Eternal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]));
                    GoalList.Add(eternalGoal);
                }
                else if (parts[0] == "Checklist")
                {
                    Checklist checklistGoal = new Checklist(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), int.Parse(goalInfo[3]), int.Parse(goalInfo[4]), int.Parse(goalInfo[5]), bool.Parse(goalInfo[6]));
                    GoalList.Add(checklistGoal);
                }
            }
        }
        //! Cannot get points added, or goals to be checked off.
        // TODO Make sure that you are able to get the goal checked off and that points are added.
        // TODO also make sure to add a TotalPoints variable where all points are added to it.
        else if (selection == 5)
        {
            Console.WriteLine("Record Event!");
            foreach (Goal goal in GoalList)
            {
                Console.WriteLine(goal.GetGoalInfo());
            }
            Console.Write("\nWhich goal would you like to complete?: ");
            int readChoice = int.Parse(Console.ReadLine());
            GoalList[readChoice-1].isComplete();
        }
        // else if (selection == 5)
        // {
        //     Console.WriteLine("Record Event!!");
        //     foreach (Goal goal in GoalList)
        //     {
        //         Console.WriteLine(goal);
        //     }
        //     Console.Write("Which goal would you like to mark complete?: ");
        //     int recordSelection = int.Parse(Console.ReadLine());
        //     GoalList[recordSelection-1]
        //     Console.WriteLine(GoalList[recordSelection-1]);
        // }

        else if (selection == 6)
        {
            break;
        }
        }
    }
}