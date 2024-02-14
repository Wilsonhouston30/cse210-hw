using System;
using System.Net.Mail;
using System.Threading.Tasks.Dataflow;
class Program
{
    static void Main(string[] args)
    {

        string UserInput = "0";
        Journal journal = new Journal();
        var date = DateTime.Now;



        while (UserInput != "5")
        {

            Console.WriteLine("Please select one of the options below:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
                Console.Clear();
                Console.WriteLine("You've Selected Write");
                PromptGen promtgenerator = new PromptGen();
                string promt = promtgenerator.GetPromt();
                Console.WriteLine($"Promt: {promt} ");
                Console.WriteLine();
                string UserPromtAnswer = Console.ReadLine();


                Journal jornal1 = new Journal();
                journal.AddEntry(UserPromtAnswer);
                Console.Clear();
            }
            else if (UserInput == "2")
            {
                Console.Clear();
                List<string> entries = journal.GetEntries();
                foreach (string entry in entries)
                {
                    Console.WriteLine();
                    Console.WriteLine(date.ToString("MM/dd/yyyy"));
                    Console.WriteLine($"Entry: {entry}");

                }
                Console.WriteLine();
            }
            else if (UserInput == "3")
            {
                Console.Clear();
                Console.WriteLine("You've selected 3");
                Console.WriteLine();
            }
            else if (UserInput == "4")
            {
                Console.Clear();
                Console.WriteLine("You've selected 4");
                Console.WriteLine();
            }

        }
    }
}