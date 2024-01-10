using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        var userGrade = Console.ReadLine();
        var plusMinus = userGrade[1];
        int userNum = int.Parse(userGrade);
        var letterGrade = "";
        Console.WriteLine(plusMinus);


        if (userNum >= 90)
        {
            letterGrade = "A";
        }
        else if (userNum >= 80)
        {
            letterGrade = "B";
        }
        else if (userNum >= 70)
        {
            letterGrade = "C";
        }
        else if (userNum >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is a: {letterGrade}");

        if (userNum >= 70)
        {
            System.Console.WriteLine("You are passing the class!");
        }
        else
        {
            System.Console.WriteLine("Keep on working, you will get better! ");
        }

    }
}