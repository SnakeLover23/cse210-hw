public class Listing : Activity
{
    private int _seconds = 0;
    private List<string> _prompts = new List<string>();
    private Random rng = new Random();
    public Listing() : base("listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
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

        Console.WriteLine("List as many responces to the following prompt as you can:");
        Console.WriteLine("");
        int number = rng.Next(0, _prompts.Count);
        Console.WriteLine($"---{_prompts[number]}---");
        Console.WriteLine("");
        Console.Write("You may begin in ");
        CountDown(count: 3);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        do
        {
            Console.ReadLine();

            currentTime = DateTime.Now;
        } while (currentTime < endTime);
        Console.WriteLine("");
        EndMessage();
    }
}