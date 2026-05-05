using System;

class Program
{
    static bool IsPrime(int n)
    {
        if(n < 2) return false;

        for(int i=2;i<n;i++)
        {
            if(n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine(IsPrime(11));
    }
}