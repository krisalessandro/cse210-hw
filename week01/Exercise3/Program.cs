using System;

class Program
{
    static void Main(string[] args)
    {
        int guess, attempt=1;
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 10);
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
            attempt++;

        } while (MagicNumber != guess);

        Console.WriteLine($"You guessed it! in {attempt} attempts.");
    }
}