using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1.Add 2.Exit");
        int ch = int.Parse(Console.ReadLine());

        if(ch==1)
        {
            int a=5,b=5;
            Console.WriteLine(a+b);
        }
    }
}