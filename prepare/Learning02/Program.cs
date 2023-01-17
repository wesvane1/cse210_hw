using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1=new Job();
        job1._jobTitle="Software Engineer";
        job1._company="Amazon";
        job1._startYear="2023";
        job1._endYear="2024";

        Job job2= new Job();
        job2._jobTitle="UI/UX Design";
        job2._company="Microsoft";
        job2._startYear="2024";
        job2._endYear="present";

        Resume myResume =new Resume();
        myResume._name="Wesley Vane";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.display();
    }
}