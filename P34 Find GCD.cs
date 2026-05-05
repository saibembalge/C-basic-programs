using System;

class Program
{
    static void Main()
    {
        int a = 24, b = 36;
        int gcd = 1;

        for(int i=1;i<=a && i<=b;i++)
        {
            if(a%i==0 && b%i==0)
                gcd = i;
        }

        Console.WriteLine("GCD = " + gcd);
    }
}