using System;
using System.Threading;

class Program
{
    static void Main()
    {
        for(int i=5;i>=1;i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}