using System;

class Program
{
    static void Table(int n)
    {
        for(int i=1;i<=10;i++)
            Console.WriteLine(n*i);
    }

    static void Main()
    {
        Table(5);
    }
}