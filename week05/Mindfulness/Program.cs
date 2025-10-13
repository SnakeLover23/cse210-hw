using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool exit = false;
        do
        {
            Console.WriteLine("Menue Options: ");
            Console.WriteLine(" 1) Breathing Activity");
            Console.WriteLine(" 2) Reflection Activity");
            Console.WriteLine(" 3) Listing Activity");
            Console.WriteLine(" 4) Quit");
            Console.Write("Select a choice from the menue: ");
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                Breathing breathing = new Breathing();
                breathing.Start();
            }
            else if (input == "2")
            {
                Reflection reflection = new Reflection();
                reflection.Start();
            }
            else if (input == "3")
            {
                Listing listing = new Listing();
                listing.Start();
            }
            else if (input == "4")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("I don't understand.");
                Console.WriteLine("Press [Enter] to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (exit == false);
        Console.Clear();
        Console.WriteLine("Goodbuy");
    }
}