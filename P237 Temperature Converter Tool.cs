using System;

class Program
{
    static void Main()
    {
        Console.Write("Celsius: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine((c*9/5)+32);
    }
}