using System;

class Program
{
    public static List<string> Activities = new List<string>();
    static void Main(string[] args)
    {

        Running r1 = new Running("March 27, 2023", "Running", 28, 2.4);
        Activities.Add(r1.GetSummary());

        Swimming s1 = new Swimming("March 27, 2023", "Swimming", 20, 40);
        Activities.Add(s1.GetSummary());

        Cycling c1 = new Cycling("March 27, 2023", "Cycling", 90, 25.6);
        Activities.Add(c1.GetSummary());

        int count = 1;
        foreach (string activity in Activities)
        {
            Console.WriteLine($"\nActivity {count}");
            Console.WriteLine(activity);
            count ++;
        }
    }
}