using System;

class Program
{
    static int CountDigits(int n)
    {
        int count = 0;
        while(n > 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }

    static void Main()
    {
        Console.WriteLine(CountDigits(12345));
    }
}