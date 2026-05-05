using System;

class Program
{
    static void Main()
    {
        Console.Write("2 x 3 = ");
        int ans = int.Parse(Console.ReadLine());

        Console.WriteLine(ans == 6 ? "Correct" : "Wrong");
    }
}