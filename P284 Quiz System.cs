using System;

class Program
{
    static void Main()
    {
        Console.Write("2+2=");
        int ans = int.Parse(Console.ReadLine());

        Console.WriteLine(ans==4?"Correct":"Wrong");
    }
}