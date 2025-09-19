using System;
using System.Collections.Generic;
using System.Diagnostics;

public class WriteJrnl
{
    public List<DatedJournal> _datedJournals = new List<DatedJournal>();


    public List<string> _promt = new List<string>
    {
        "What is a small detail you noticed today that you've never paid attention to before?",
        "Describe a moment today when you felt truly alive. What were you doing and who were you with?",
        "If you could have a conversation with your future self, what is one question you would ask them and one piece of advice you would give?",
         "Write about a song you heard today. What memories or feelings does it bring up for you?",
        "What's one thing that happened today that you're proud of, no matter how small?",
        "Imagine you're the main character in a movie. Describe the scene you're currently in.",
        "What is a challenge you faced today, and how did you handle it? If you didn't handle it well, what would you do differently?",
        "Describe a person you encountered today. What did you notice about them, and what is something you imagine their story might be?",
        "What is a goal you're working towards? Write about your progress, setbacks, or a small step you can take tomorrow to move closer to it.",
        "If you had to teach someone one skill you learned today (even a simple one like how to make a coffee), what would it be and how would you explain it?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void Display(int process, string filename)
    {
        foreach (DatedJournal datedJournal in _datedJournals)
        {
            datedJournal.Display(process,filename);
        }
        if (process == 1)
        {
            Console.WriteLine("File saving was succesfully completed...");
        }
    }


}