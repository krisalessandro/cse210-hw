using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int item = 1;
        double avg, sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (item != 0)
        {
            Console.Write("Enter number: ");
            item = int.Parse(Console.ReadLine());

            if (item == 0)
            {
                break;
            }
            else
            {
                numbers.Add(item);
            }

        }
        foreach (int numero in numbers)
        {
            sum = sum + numero;


        }

        Console.WriteLine($"The sum is: {sum}");

        avg = sum / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        Console.WriteLine($"The larger number is: {numbers.Max()}");
        

    }
}