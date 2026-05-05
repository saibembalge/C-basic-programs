using System;

class Program
{
    static int LCM(int a, int b)
    {
        return (a*b)/GCD(a,b);
    }

    static int GCD(int a, int b)
    {
        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        Console.WriteLine(LCM(12,18));
    }
}