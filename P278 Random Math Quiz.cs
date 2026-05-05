using System;

class Program
{
    static void Main()
    {
        Random r = new Random();

        int a = r.Next(1,10);
        int b = r.Next(1,10);

        Console.Write($"{a}+{b}=");
        int ans = int.Parse(Console.ReadLine());

        Console.WriteLine(ans == a+b ? "Correct":"Wrong");
    }
}