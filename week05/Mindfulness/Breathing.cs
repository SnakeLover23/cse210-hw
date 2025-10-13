using System.Security.Cryptography.X509Certificates;

public class Breathing : Activity
{
    private int _seconds = 0;
    public Breathing() : base("breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void Start()
    {
        StartMessage();
        string input = Console.ReadLine();
        _seconds = int.Parse(input);
        SetSeconds(_seconds);
        Console.Clear();
        Console.WriteLine("Get Ready");
        Spinner();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        do
        {
            Console.Write("Breathe in... ");
            CountDown(count: 3);
            Console.Write("Breathe out... ");
            CountDown(count: 5);
            Console.WriteLine("");

            currentTime = DateTime.Now;
        } while (currentTime < endTime);
        EndMessage();
    }
}