using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Give me a grade nummber. (0 - 100) ");
        string grade = Console.ReadLine();
        int intgrade = int.Parse(grade);

        string lettergrade;

        if (intgrade >= 90)
        {
            lettergrade = "A";
        }
        else if (intgrade >= 80)
        {
            lettergrade = "B";
        }
        else if (intgrade >= 70)
        {
            lettergrade = "C";
        }
        else if (intgrade >= 60)
        {
            lettergrade = "D";
        }
        else if (intgrade < 0)
        {
            lettergrade = "Inv";
        }
        else if (intgrade < 60)
        {
            lettergrade = "F";
        }
        else
        {
            lettergrade = "Inv";
        }

        Console.WriteLine($"Your grade is {lettergrade}.");

        if (intgrade >= 70)
        {
            Console.WriteLine("Congradulations, you pass the class!");
        }
        else
        {
            Console.WriteLine("You need to do better.");
        }
    }
}