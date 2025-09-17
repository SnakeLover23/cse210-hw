using System;

class Program
{
    static void Main(string[] args)
    {
        string fractionString = "";
        double fractionDouble = 0;
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        fractionString = fraction1.GetFractionString();
        Console.WriteLine(fractionString);
        fractionDouble = fraction1.GetDecimalValue();
        Console.WriteLine(fractionDouble);

        fractionString = fraction2.GetFractionString();
        Console.WriteLine(fractionString);
        fractionDouble = fraction2.GetDecimalValue();
        Console.WriteLine(fractionDouble);

        fractionString = fraction3.GetFractionString();
        Console.WriteLine(fractionString);
        fractionDouble = fraction3.GetDecimalValue();
        Console.WriteLine(fractionDouble);

        fractionString = fraction4.GetFractionString();
        Console.WriteLine(fractionString);
        fractionDouble = fraction4.GetDecimalValue();
        Console.WriteLine(fractionDouble);
    }
}