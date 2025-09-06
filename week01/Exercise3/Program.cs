using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        Console.Write("Type the Magic number: ");
        int MagicNumber = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == MagicNumber)
            {
                break;
            }
            else if (guess > MagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

        } while (MagicNumber != guess);

        Console.WriteLine("You guessed it!");
    }
}