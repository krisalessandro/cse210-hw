using System.IO;
public class DatedJournal

{
    public string _date;
    public string _text;

    public string _promt;


    public void Display(int process, string filename)
    {
        string format = $"\nDate: {_date} - Promt: {_promt}\n {_text}";
        if (process == 0)
        {

            Console.WriteLine(format);

        }
        else if (process == 1)
        {

            using (StreamWriter outputfile = new StreamWriter(filename,true))
            {
                outputfile.WriteLine(format + ",");
                
            }
        }

    }

}