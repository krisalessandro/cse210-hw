using System;
using System.Threading.Tasks.Dataflow;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int end = 0;
        string choice ="";
        Console.WriteLine("Welcome to the Journal Program!");
        WriteJrnl write = new WriteJrnl();
        
        while (end == 0)
        {

            Console.WriteLine("Please select one of the following choices: ");
            Console.Write("1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \n What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {

                DatedJournal journal = new DatedJournal();
                Random random = new Random();

                int randomIndex = random.Next(write._promt.Count);

                journal._promt = write._promt[randomIndex];

                Console.Write($"{journal._promt}\n> ");

                journal._text = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                journal._date = theCurrentTime.ToShortDateString();

                write._datedJournals.Add(journal);
            }
            else if (choice == "2")//dispaly the current entries
            {
                write.Display(0, "");
            }
            else if (choice == "3")//load entries from a file
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string firstpart = parts[0];

                    Console.WriteLine(firstpart);

                }
            }
            else if (choice == "4")//save entries into a file
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                write.Display(1, filename);
            }
            else if (choice == "5")
            {
                break;

            }
            else
            {
                Console.WriteLine("\nInvalid value try again...\n");
            }

        }


    }
}