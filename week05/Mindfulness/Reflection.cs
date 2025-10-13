public class Reflection : Activity
{
    private int _seconds = 0;
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private Random rng = new Random();
    public Reflection() : base("reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the future? ");
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
        
        Console.WriteLine("Consider the folowing prompt:");
        Console.WriteLine("");
        int number = rng.Next(0, _prompts.Count);
        Console.WriteLine($"---{_prompts[number]}---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind press [Enter] to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on the folowing questions as they related to this experiance.");
        Console.Write("You may begin in ");
        CountDown(count: 3);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        do
        {
            number = rng.Next(0, _questions.Count);

            Console.Write(_questions[number]);
            Spinner();

            currentTime = DateTime.Now;
        } while (currentTime < endTime);
        Console.WriteLine("");
        EndMessage();
    }
}