using System;

class Program
{
    static void Main(string[] args)
    {
        string letter, text;
        bool pass = true;
        
        Console.Write("Type your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
            pass = false;
        }

        if (pass) {
            text = $"Congratulations! You passed the course with a {letter} grade.";
        } else {
            text = $"You got a {letter}. Don't worry, you can do it next time. Keep practicing!";
        }


        Console.WriteLine(text);

    }
}