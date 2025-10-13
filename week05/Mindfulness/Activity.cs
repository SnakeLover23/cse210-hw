public class Activity
{
    private string _name = "";
    private int _seconds = 0;
    private string _desctiption;
    public Activity(string name, string description)
    {
        _name = name;
        _desctiption = description;
    }
    public int GetSeconds()
    {
        return _seconds;
    }
    public void SetSeconds(int seconds)
    {
        _seconds = seconds;
    }
    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine("");
        Console.WriteLine(_desctiption);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like this session to be: ");
    }
    public void EndMessage()
    {
        Console.WriteLine("Well Done");
        Spinner();
        Console.WriteLine($"You have completed {_seconds} seconds of the {_name} activity.");
        Spinner();
        Console.Clear();
    }
    public void Spinner(int count = 3, int time = 400)
    {
        do
        {
            Console.Write("\\");
            Thread.Sleep(time);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(time);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(time);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(time);
            Console.Write("\b \b");

            count = count - 1;

        } while (count > 0);
        Console.WriteLine("");
    }
    public void CountDown(int count = 5, int time = 1000)
    {
        do
        {
            Console.Write(count);
            Thread.Sleep(time);
            Console.Write("\b \b");
            count = count - 1;
        } while (count > 0);
        Console.WriteLine("");
    }
}