using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int fnumber = PromptUserNumber();

        int sqr = SquareNumber(fnumber);

        DisplayResult(name, sqr);



        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string variable = Console.ReadLine();

            return variable;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int var = int.Parse(Console.ReadLine());

            return var;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

    }
}