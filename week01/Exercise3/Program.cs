using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool end = false;
        do
        {
            bool correct = false;
            Console.WriteLine("Im thinking of a number between 1 and 100.");
            int number = randomGenerator.Next(1, 101);
            do
            {
                Console.Write("What is your guess? ");
                string inpt = Console.ReadLine();
                int guess = int.Parse(inpt);
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess == number)
                {
                    correct = true;
                }
            } while (correct == false);
            Console.WriteLine("Congradulations, you guessed the magic number!");
            bool loop = true;
            do
            {
                Console.Write("Do you want to play again? ");
                string inpt = Console.ReadLine();
                if (inpt == "yes")
                {
                    loop = false;
                    Console.WriteLine("");
                }
                else if (inpt == "no")
                {
                    loop = false;
                    end = true;
                }
                else
                {
                    Console.WriteLine("I don't understand, please input [yes] or [no].");
                }
            } while (loop == true);
        } while (end == false);
        Console.WriteLine("Goodbuy");
    }
}