using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f = new Fractions(3, 4);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

    }
}