using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.Clear();

        Job job1 = new Job();
        job1._companyName = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2022;
        Job job2 = new Job();
        job2._companyName = "Microsoft";
        job2._jobTitle = "Senior Developer";
        job2._startYear = 2022;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._memberName = "Wilson Houston";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        resume1.Display();



    }
}