using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Gage", "Programing");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();
        MathAssignment assignment2 = new MathAssignment("5.1", "1-4", "Gage", "Math");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment assignment3 = new WritingAssignment("Silverwing by Kenneth Oppel", "Gage", "Writing");
        Console.WriteLine(assignment3.GetWritingInformation());
        Console.WriteLine();
    }
}