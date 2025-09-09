using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finnished");
        List<float> numbers = new List<float>();
        bool end = false;
        float largest = 0;
        float total = 0;
        float average = 0;
        int count = 0;
        do
        {
            Console.Write("Enter number: ");
            string inpt = Console.ReadLine();
            float number = float.Parse(inpt);
            if (number > largest)
            {
                largest = number;
            }
            if (number == 0)
            {
                end = true;
            }
            else
            {
                numbers.Add(number);
            }
        } while (end == false);
        foreach (float i in numbers)
        {
            total = total + i;
            count = count + 1;
        }
        average = total / count;
        Console.WriteLine($"The total is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}