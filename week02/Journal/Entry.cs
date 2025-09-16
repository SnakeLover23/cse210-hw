using System.Globalization;

public class Entry
{
    public List<List<string>> _entrys = new List<List<string>>();

    public void NewEntry()
    {
        List<string> entry = new List<string>();
        string prompt = Prompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("New entry: ");
        DateTime time = DateTime.Now;
        string date = time.ToShortDateString();
        string inpt = Console.ReadLine();
        Console.WriteLine("");
        entry.Add(date);
        entry.Add(prompt);
        entry.Add(inpt);
        _entrys.Add(entry);
    }
    public void Display()
    {
        foreach (List<string> entry in _entrys)
        {
            Console.WriteLine($"Date: {entry[0]}");
            Console.WriteLine($"Prompt: {entry[1]}");
            Console.WriteLine($"Entry: {entry[2]}");
            Console.WriteLine("");
        }
        Console.Write("Press [Enter] to continue.");
        string stop = Console.ReadLine();
        Console.WriteLine("");
    }
    static string Prompt()
    {
        Random rng = new Random();
        int number = rng.Next(1, 6);
        if (number == 1)
        {
            return "What is something fun you did today?";
        }
        else if (number == 2)
        {
            return "Did you have a funny dream last night?";
        }
        else if (number == 3)
        {
            return "Did you let your intrusive thoughts win?";
        }
        else if (number == 4)
        {
            return "Did you help anyone today?";
        }
        else if (number == 5)
        {
            return "What superpower do you want most?";
        }
        else
        {
            return "This prompt shouldn't exist. What did you do?";
        }
    }
}